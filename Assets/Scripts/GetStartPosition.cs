using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class GetStartPosition : MonoBehaviour
{
    private StartPoint _startPoint;

    private void Start()
    {
        _startPoint = FindObjectOfType<StartPoint>();
        transform.position = (_startPoint.transform.position);
    }
}
