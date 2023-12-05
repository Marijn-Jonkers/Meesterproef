using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Renderer Renderer;
    public GameObject GameObject;
    [SerializeField] private Color red;
    // Start is called before the first frame update
    void Start()
    {
        Renderer = GameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMaterial()
    {
        Renderer.material.color= red;
    }
}
