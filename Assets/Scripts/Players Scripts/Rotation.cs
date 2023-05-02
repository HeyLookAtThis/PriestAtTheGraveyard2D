using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class Rotation : MonoBehaviour
{
    private const string Horizontal = "Horizontal";

    private float _axis = 180;
    private Quaternion _rotation;

    private void FixedUpdate()
    {
        if (Input.GetAxis(Horizontal) == -1)
        {
            transform.rotation = Quaternion.identity;
        }
        else if (Input.GetAxis(Horizontal) == 1)
        {
            _rotation.y = _axis;
            transform.rotation = _rotation;
        }
    }
}
