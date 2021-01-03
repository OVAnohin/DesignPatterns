using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private GameObject _actor;

    private Animator _animator;
    private Command _keyJump, _keyP, _keyK, _upArrow;

    private void Start()
    {
        _keyJump = new PerformJump();
        _keyP = new PerformPunch();
        _keyK = new PerformKick();
        _upArrow = new MoveForward();
        _animator = _actor.GetComponent<Animator>();
        Camera.main.GetComponent<CameraFollow360>().InitTarger(_actor.transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.Space))
        {
            _keyJump.Execute(_animator);
        }
        else if(Input.GetKeyDown(KeyCode.P))
        {
            _keyP.Execute(_animator);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            _keyK.Execute(_animator);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _upArrow.Execute(_animator);
        }
    }
}
