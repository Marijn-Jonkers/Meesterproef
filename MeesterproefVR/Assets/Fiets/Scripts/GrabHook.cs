using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabHook : MonoBehaviour
{
    public GameObject fiets;
    public Transform HookPos;
    public Vector3 axis;

    private HingeJoint joint;
    private bool attatched = false;

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == gameObject.tag && !attatched)
        {
            attatched = true;
            Debug.Log("Now I'm Triggered!");
            gameObject.transform.position = HookPos.transform.position;
            gameObject.transform.rotation = HookPos.transform.rotation;
            joint = gameObject.AddComponent<HingeJoint>();
            joint.connectedBody = fiets.GetComponent<Rigidbody>();
            joint.axis = axis;
        }
    }

}
