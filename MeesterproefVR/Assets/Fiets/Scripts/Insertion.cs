using System.Collections;
using UnityEngine;

public class Insertion : MonoBehaviour
{
    public Transform inserted;
    public Transform linearPathStart;
    public Transform linearPathEnd;
    public LineRenderer pathRenderer;
    public Renderer refCube;
    public Material m1;
    public Material m2;
    public Material m3;

    private bool onTrack = false;
    private bool lockedInPlace = false;

    void Start()
    {
        refCube.material = m1;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InsertionPoint") && !onTrack)
        {
            refCube.material = m2;

            // Snap into place
            onTrack = true;
            GetComponent<Rigidbody>().isKinematic = true;
            transform.position = inserted.position;
        }
        if (other.CompareTag("PathEnd") && onTrack)
        {
            refCube.material = m3;

            // Lock in place at the bottom
            onTrack = false;
            lockedInPlace = true;
            GetComponent<Rigidbody>().isKinematic = true;
        }
        if (other.CompareTag("PathStart") && onTrack)
        {
            refCube.material = m1;

            // Remove restrictions at the top
            onTrack = false;
            lockedInPlace = false;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }

    void FixedUpdate()
    {
        if (onTrack && !lockedInPlace)
        {
            // Move along the path defined by the Line Renderer
            MoveAlongPath();
        }
    }

    void MoveAlongPath()
    {
        // Calculate the percentage of distance covered along the path
        float distanceCovered = Vector3.Distance(transform.position, linearPathStart.position);
        float totalDistance = Vector3.Distance(linearPathStart.position, linearPathEnd.position);
        float percentage = distanceCovered / totalDistance;

        // Interpolate along the Line Renderer positions based on the percentage
        Vector3 targetPosition = Vector3.Lerp(pathRenderer.GetPosition(0), pathRenderer.GetPosition(pathRenderer.positionCount - 1), percentage);

        // Update the rigidbody position using physics
        GetComponent<Rigidbody>().MovePosition(targetPosition);
    }
}
