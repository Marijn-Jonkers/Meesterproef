using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentToWithInteraction : MonoBehaviour
{
    public GameObject self;
    public GameObject target;
    public bool DeleteCollider = false;
    [Optional]
    public Collider Collider;
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == gameObject.tag)
        {
            target.SetActive(true);
            self.SetActive(false);
            if(DeleteCollider == true)
            {
                Destroy(Collider);
            }
        }
    }
}