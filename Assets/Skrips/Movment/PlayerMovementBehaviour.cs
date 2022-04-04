using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;
    private Vector3 _moveDirection;
    private Vector2 _rotationDirection;
    private Camera _camera;
    [SerializeField]
    private float _rotationspeedY;
    [SerializeField]
    private float _rotationSpeedX;

    public Vector3 MoveDirection 
    {
        get { return _moveDirection; }
        set { _moveDirection = value; }
    }
    public Vector2 MouseDirection 
    {
        get { return _rotationDirection; }
        set { _rotationDirection = value; }
    }

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _camera = GetComponentInChildren<Camera>();
    }
    //update
    private void FixedUpdate()
    {
        Quaternion playerRotation = Quaternion.Euler(0,transform.rotation.eulerAngles.y + MouseDirection.x * _rotationspeedY * Time.deltaTime,0);
        
        float cameraXRotation = Mathf.Clamp(transform.localRotation.eulerAngles.x + MouseDirection.y * _rotationspeedY * Time.deltaTime, -89, 89);

        Quaternion cameraRotaiton = Quaternion.Euler(cameraXRotation,0,0);

        _rigidbody.MoveRotation(playerRotation);

        _camera.transform.Rotate(new Vector3(-cameraXRotation, 0, 0) * Time.deltaTime * _rotationSpeedX);
       // _camera.transform.localRotation = cameraRotaiton;

        //tells the rigidbody to move to a position
        Vector3 velocity = MoveDirection * _speed * Time.deltaTime;
        _rigidbody.MovePosition(transform.position + velocity);
        
    }
}
