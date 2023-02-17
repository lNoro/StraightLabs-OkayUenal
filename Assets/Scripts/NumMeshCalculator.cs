using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumMeshCalculator : MonoBehaviour
{
    private List<Transform> _primitives;

    // Update is called once per frame
    void Update()
    {
        // Only here because worksheet said so... Otherwise moved this to the button mechanic (no continuous update calls necessary)
        Debug.Log(CalculateNumMeshes());
    }

    
    public int CalculateNumMeshes()
    {
        // Go through each primitive and check if in camera frustum
        int num = 0;
        foreach (var primitive in _primitives)
        {
            if (primitive.GetComponent<MeshView>() != null && primitive.GetComponent<MeshView>().CalculateMeshInView())
                num++;
        }

        return num;
    }


    //Gets all children and adds them into the PrimitivesList
    public void UpdatePrimitiveList()
    {
        _primitives = new List<Transform>();
        foreach (Transform primitive in transform)
        {
            _primitives.Add(primitive);
        }
    }
    
    /*
     * NOTE: This mesh counter logic could also be done more efficiently with an event manager like pattern...
     * with functions like OnBecame(In)Visible(), an event function could be invoked which manages the overall count of meshes...
     * idea came to late to implement...
     */
}
