using System;
using UnityEngine;

public class Car : MonoBehaviour {
    [SerializeField] private WheelCollider _leftFrontWhell;
    [SerializeField] private WheelCollider _rightFrontWhell;

    [SerializeField] private float _maxMotorTorque = 10f;
    [SerializeField] private float _maxSteerAngle = 10f;
    [SerializeField] private Transform _centerOfMass;
    
    private Rigidbody _rigidbody;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.centerOfMass = _centerOfMass.position;
        name = "Car";
    }

    private void FixedUpdate() {
        _leftFrontWhell.motorTorque = Input.GetAxis("Vertical") * _maxMotorTorque;
        _rightFrontWhell.motorTorque = Input.GetAxis("Vertical") * _maxMotorTorque;
        
        _leftFrontWhell.steerAngle = Input.GetAxis("Horizontal") * _maxSteerAngle;
        _rightFrontWhell.steerAngle = Input.GetAxis("Horizontal") * _maxSteerAngle;
    }
}
