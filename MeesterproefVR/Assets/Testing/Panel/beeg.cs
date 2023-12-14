using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class beeg : MonoBehaviour
{
    public Slider scaleSlider;
    public GameObject monki;

    private float scaleSliderNumber;



    void Update()
    {
        scaleSliderNumber = scaleSlider.value;
        Vector3 scale = new(scaleSliderNumber,scaleSliderNumber, scaleSliderNumber);
        monki.transform.localScale = scale;

    }
}
