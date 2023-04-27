using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(EarthTrigger))]

public class Jump : MonoBehaviour
{
    private static string Vertical = "Vertical";

    [SerializeField] private float _jumpHeight = 7.3f;

    private Rigidbody2D _rigidbody;
    private EarthTrigger _trigger;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _trigger = GetComponent<EarthTrigger>();
    } 

    private void FixedUpdate()
    {
        if (Input.GetAxis(Vertical) > 0 && _trigger.IsGround)
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpHeight);
    }
}
