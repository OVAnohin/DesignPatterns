using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShipMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private InputActions _playerInput;

    private void Awake()
    {
        _playerInput = new InputActions();
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void Update()
    {
        Vector2 direction = _playerInput.Ship.Move.ReadValue<Vector2>();
        Move(direction);
    }

    private void Move(Vector2 direction)
    {
        Vector3 newPosition = transform.position + new Vector3(direction.x, direction.y, 0);
        transform.position = Vector2.MoveTowards(transform.position, newPosition, _speed * Time.deltaTime);
    }
}
