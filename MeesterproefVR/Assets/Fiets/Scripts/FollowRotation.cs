using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRotation : MonoBehaviour
{
    public GameObject Parent;
    public float Factor = 1;


    void Start()
    {
        
    }

    void Update()
    {
        Quaternion rotation = Parent.transform.localRotation;
        transform.localRotation = rotation;
        
    }
}
