using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShipControl : MonoBehaviour
{
    protected InputActions PlayerInput;

    private void Awake()
    {
        PlayerInput = new InputActions();
    }

    private void OnEnable()
    {
        PlayerInput.Enable();
    }

    private void OnDisable()
    {
        PlayerInput.Disable();
    }
}
