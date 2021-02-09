using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Rocket : MonoBehaviour
{
    public event UnityAction AsteroidHitting;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Ship>() != null)
            return;

        if (collision.GetComponent<Asteroid>() != null)
            AsteroidHitting?.Invoke();

        gameObject.SetActive(false);
    }
}
