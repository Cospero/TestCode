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
        if (Input.GetKey(KeyCode.W))
        {
            
            _rigidbody.AddForce(Vector3.forward*_speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rigidbody.AddForce(Vector3.back*_speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rigidbody.AddForce(Vector3.right*_speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rigidbody.AddForce(Vector3.left*_speed);
        }
        
        
    }
}
