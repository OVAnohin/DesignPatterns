using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 2.0f;
    [SerializeField] private float _rotationSpeed = 100.0f;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void LateUpdate()
    {
        float translation = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");

        Move(translation, rotation);

        //if (Input.GetKeyDown(KeyCode.Space))
        //    _animator.SetTrigger("isJumping");
        //else if (Input.GetKeyDown(KeyCode.P))
        //    _animator.SetTrigger("isPunching");
        //else if (Input.GetKeyDown(KeyCode.K))
        //    _animator.SetTrigger("isKicking");

    }

    private void Move(float translation, float rotation)
    {
        translation *= _speed * Time.deltaTime;
        rotation *= _rotationSpeed * Time.deltaTime;

        if (translation != 0 || rotation != 0)
        {
            _animator.SetBool("isWalking", true);
            transform.Translate(0, 0, translation);
            transform.Rotate(0, rotation, 0);
        }
        else
        {
            _animator.SetBool("isWalking", false);
        }
    }
}
