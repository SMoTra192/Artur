using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class Move : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FloatingJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _movespeed;

    // Start is called before the first frame update
   
    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _movespeed, _rigidbody.velocity.y,
            _joystick.Vertical * _movespeed);
        if (_joystick.Horizontal != 0 && _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isRunning",true );
            
        }
        else
        {
            _animator.SetBool("isRunning",false);
        }
        
    }
}
