using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class ChestOpener : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Activate()
    {
        _animator.SetBool(ACChest.Params.IsPlayerEnter, true);
    }
}
