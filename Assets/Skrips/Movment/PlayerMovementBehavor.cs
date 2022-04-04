using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavor : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

}
