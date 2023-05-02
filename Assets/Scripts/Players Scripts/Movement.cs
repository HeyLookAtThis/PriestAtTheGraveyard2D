using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Movement : MonoBehaviour
{
    private const string Horizontal = "Horizontal";

    [SerializeField] private float _speed = 3.0f;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float moveDirection = Input.GetAxis(Horizontal);
        _rigidbody.velocity = new Vector2(moveDirection * _speed, _rigidbody.velocity.y);
    }
}
