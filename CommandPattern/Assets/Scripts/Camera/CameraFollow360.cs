﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow360 : MonoBehaviour
{

    [SerializeField] private Transform _target;
    [SerializeField] private float _distance = 10;
    [SerializeField] private float _height = 5;
    [SerializeField] private Vector3 _lookOffset = new Vector3(0, 1, 0);
    [SerializeField] private float _cameraSpeed = 10;
    [SerializeField] private float _rotationSpeed = 10;
    [SerializeField] private float _delay = 0.1f; // из за него работает плавно!!!!

    void FixedUpdate()
    {
        Vector3 lookPosition = _target.position + _lookOffset;
        Vector3 relativePosition = lookPosition - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePosition);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * _rotationSpeed * _delay);

        Vector3 targetPos = _target.transform.position + _target.transform.up * _height - _target.transform.forward * _distance;

        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * _cameraSpeed * _delay);
    }
}