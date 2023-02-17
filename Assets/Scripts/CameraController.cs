using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    private InputAction _click;
    private CinemachineInputProvider _input;
    
    private void Awake()
    {
        _input = GetComponent<CinemachineInputProvider>();
        _click = new InputAction(binding: "<Mouse>/leftButton");
        
        // Enable Camera Movement while holding Left Mouse Button
        _click.performed += _ => { _input.enabled = true; };
        _click.canceled += _ => { _input.enabled = false; };
    }

    private void OnEnable()
    {
        _click.Enable();
    }

    private void OnDisable()
    {
        _click.Disable();
    }
}
