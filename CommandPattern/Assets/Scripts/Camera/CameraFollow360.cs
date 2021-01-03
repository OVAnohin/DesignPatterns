using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow360 : MonoBehaviour
{ 
    [SerializeField] private float _distance;
    [SerializeField] private float _height;
    [SerializeField] private float _cameraSpeed;
    [SerializeField] private float _rotationSpeed;

    private Transform _target;
    private Vector3 _lookOffset;

    private void Start()
    {
        _lookOffset = new Vector3(0, _height, 0);
    }

    private void FixedUpdate()
    {
        Vector3 lookPosition = _target.position + _lookOffset;
        Vector3 relativePosition = lookPosition - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePosition);

        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * _rotationSpeed);

        Vector3 targetPos = _target.position + _target.up * _height - _target.forward * _distance;
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * _cameraSpeed);
    }

    public void InitTarger(Transform transform)
    {
        _target = transform;
    }
}
