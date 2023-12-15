using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeSpherePyramid : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject pyramid;



    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            cube.SetActive(true);
            sphere.SetActive(false);
            pyramid.SetActive(false);
        }
        if (val == 1)
        {
            cube.SetActive(false);
            sphere.SetActive(true);
            pyramid.SetActive(false);
        }
        if (val == 2)
        {
            cube.SetActive(false);
            sphere.SetActive(false);
            pyramid.SetActive(true);
        }

    }
}
