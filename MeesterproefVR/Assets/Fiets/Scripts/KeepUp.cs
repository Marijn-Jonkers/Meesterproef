using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, 1, transform.position.z);
    }
}
