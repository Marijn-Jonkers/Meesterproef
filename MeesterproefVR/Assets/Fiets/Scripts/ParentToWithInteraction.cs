using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ParentToWithInteraction : MonoBehaviour
{
    public GameObject parent;
    public GameObject child;
    public Vector3 childPos = new Vector3(0, 0, 0);
    public Vector3 childRot = new Vector3(0, 0, 0);
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == gameObject.tag)
        {
            Destroy(child.GetComponent<XRGrabInteractable>());
            Destroy(child.GetComponent<Rigidbody>());
            child.transform.SetParent(parent.transform);
            child.transform.localPosition = childPos;
            child.transform.localRotation = Quaternion.Euler(childRot);
            child.GetComponent<FollowRotation>().enabled = true;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}