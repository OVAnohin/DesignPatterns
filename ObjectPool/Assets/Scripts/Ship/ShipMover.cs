using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMover : ShipControl
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector2 translation = PlayerInput.Ship.Move.ReadValue<Vector2>();
        Move(translation);
    }

    private void Move(Vector2 translation)
    {
        Vector3 newPosition = transform.position + new Vector3(translation.x, translation.y, 0);
        transform.position = Vector2.MoveTowards(transform.position, newPosition, _speed * Time.deltaTime);
    }
}
