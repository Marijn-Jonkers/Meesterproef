using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public GameObject Passtrough_Environment;
    public GameObject Virtual_Environment;

    // Update is called once per frame
    public void OnToggleChange(bool Passtrough)
    {
        if (Passtrough)
        {
            Virtual_Environment.SetActive(false);
            Passtrough_Environment.SetActive(true);
        }
        if (!Passtrough)
        {
            Virtual_Environment.SetActive(true);
            Passtrough_Environment.SetActive(false);
        }
    }
}
