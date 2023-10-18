using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;  
    private Rigidbody _rigidbody;

    private void Start() 
    {
        _rigidbody=GetComponent<Rigidbody>();
    }

    private void Update() 
    {
        _rigidbody.AddForce(Vector3.up*_speed);
    }
}
