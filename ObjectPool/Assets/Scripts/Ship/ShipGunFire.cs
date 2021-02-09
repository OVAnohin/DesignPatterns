using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipGunFire : ShipControl
{
    [SerializeField] private GameObject _rocketPrefab;

    private void Start()
    {
        PlayerInput.Ship.Shoot.performed += OnShoot;
    }

    private void OnShoot(InputAction.CallbackContext context)
    {
        Instantiate(_rocketPrefab, transform.position, Quaternion.identity);
    }
}
