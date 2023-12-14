using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkiSpawn : MonoBehaviour
{
    public GameObject monki;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnMonki()
    {
        Instantiate(monki);
    }
}
