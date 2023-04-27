using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class FinishPoint : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D chest)
    {
        if (chest.TryGetComponent<Player>(out Player Player))
            _animator.SetBool(ACChestGolden.Params.EnteredPlayer, true);
    }

    private void OnTriggerExit2D(Collider2D chest)
    {
        if (chest.TryGetComponent<Player>(out Player Player))
            _animator.SetBool(ACChestGolden.Params.EnteredPlayer, false);
    }
}
