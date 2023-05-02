using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class RoadLampLight : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void On()
    {
        _animator.SetBool(ACRoadLampLight.Params.IsPlayerEnter, true);
    }
}