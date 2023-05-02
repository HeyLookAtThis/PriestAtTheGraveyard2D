using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthTrigger : MonoBehaviour
{
    [SerializeField] private LayerMask _layerMask;
    private float _circleRadius = 0.01f;

    public bool IsGround { get; private set; }    

    private void Update()
    {
        IsGround = Physics2D.OverlapCircle(transform.position, _circleRadius, _layerMask);
    }
}
