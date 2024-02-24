using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pulley : MonoBehaviour
{
    bool found = false;

    void Update()
    {
        if (!found)
            if (Physics.Raycast(transform.position, transform.up, out RaycastHit hitinfo, 10f))
            {
                transform.position = hitinfo.point;
                Debug.Log("Hit " + hitinfo.collider + " at " + hitinfo.point);
                found = true;
            }
            else
            {
                Debug.DrawRay(transform.position, transform.up, Color.red);
            }
    }
}
