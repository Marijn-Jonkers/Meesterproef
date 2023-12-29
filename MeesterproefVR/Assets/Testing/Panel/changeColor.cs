using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Renderer rendererBig;
    public GameObject bigBall;
    public Renderer rendererSmall;
    public GameObject smallBall;
    public Renderer rendererRing;
    public GameObject ring;
    public Renderer rendererTotem;
    public GameObject totem;

    private bool isToggleOn = false;

    [SerializeField] private Color big1;
    [SerializeField] private Color big2;
    [SerializeField] private Color small1;
    [SerializeField] private Color small2;
    [SerializeField] private Color ring1;
    [SerializeField] private Color ring2;
    [SerializeField] private Color totem1;
    [SerializeField] private Color totem2;
    // Start is called before the first frame update
    void Start()
    {
        rendererBig = bigBall.GetComponent<Renderer>();
        rendererSmall = smallBall.GetComponent<Renderer>();
        rendererRing = ring.GetComponent<Renderer>();
        rendererTotem = totem.GetComponent<Renderer>();

        rendererBig.material.color = big1;
        rendererSmall.material.color = small1;
        rendererRing.material.color = ring1;
        rendererTotem.material.color = totem1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMaterial(bool tickOn)
    {
        if (tickOn)
        {
            rendererBig.material.color = big2;
            rendererSmall.material.color = small2;
            rendererRing.material.color = ring2;
            rendererTotem.material.color = totem2;
        }
        else
        {
            rendererBig.material.color = big1;
            rendererSmall.material.color = small1;
            rendererRing.material.color = ring1;
            rendererTotem.material.color = totem1;
        }
        isToggleOn = tickOn;
    }
}
