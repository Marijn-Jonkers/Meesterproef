using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.OpenXR.Input;

public class KeepPosRot : MonoBehaviour
{
    public bool FreezeX = false;
    public bool FreezeY = false;
    public bool FreezeZ = false;
    public bool FreezeXrot = false;
    public bool FreezeYrot = false;
    public bool FreezeZrot = false;
    private Vector3 m_OriginPos;
    private Quaternion m_OriginRot;
    void Start()
    {
        m_OriginPos = transform.localPosition;
        m_OriginRot = transform.localRotation;
    }

    void Update()
    {
        Vector3 currentPos = transform.localPosition;
        Quaternion currentRot = transform.localRotation;
        if (FreezeX)
            currentPos.x = m_OriginPos.x;
        if (FreezeY)
            currentPos.y = m_OriginPos.y;
        if (FreezeZ)
            currentPos.z = m_OriginPos.z;
        if (FreezeXrot)
            currentRot.x = m_OriginRot.x;
        if (FreezeYrot)
            currentRot.y = m_OriginRot.y;
        if (FreezeZrot)
            currentRot.z = m_OriginRot.z;
        transform.localPosition = currentPos;
        transform.localRotation = currentRot;
    }
}

