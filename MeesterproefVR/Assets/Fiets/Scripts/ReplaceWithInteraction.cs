using Oculus.Interaction;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplaceWithInteraction : MonoBehaviour
{
    public GameObject self;
    public GameObject target;
    public Collider colliderToDestroy;

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == gameObject.tag)
        {
            Debug.Log("Triggered");
            target.SetActive(true);
            Destroy(self);
            if (colliderToDestroy != null)
            {
                Destroy(colliderToDestroy.gameObject);
            }
        }
    }
}
