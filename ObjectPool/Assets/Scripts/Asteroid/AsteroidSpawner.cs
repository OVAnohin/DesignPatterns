using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _asteroidPrefab;
    [SerializeField] private float _timeBetweenSpanw;

    private float _elapsedTime;

    private void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _timeBetweenSpanw)
        {
            Instantiate(_asteroidPrefab, transform.position + new Vector3(Random.Range(-10, 10), 0, 0), Quaternion.identity, transform);
            _elapsedTime = 0;
        }
    }
}
