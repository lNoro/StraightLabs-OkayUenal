using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshView : MonoBehaviour
{
    private Camera _cam;
    private MeshRenderer _renderer;
    private Collider _collider;
    
    private void Awake()
    {
        _cam = Camera.main;
        _renderer = GetComponent<MeshRenderer>();
        _collider = GetComponent<Collider>();
    }


    //Returns if collider is in camera view frustum
    public bool CalculateMeshInView()
    {
        return GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(_cam), _collider.bounds);
    }
}
