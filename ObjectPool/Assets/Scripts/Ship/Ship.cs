using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private int _health;

    public void TakeDamage()
    {
        _health--;
        if (_health <= 0)
            Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
