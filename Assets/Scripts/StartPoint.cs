using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartPoint : MonoBehaviour
{
    [SerializeField] private Player _player;

    private void Start()
    {
        Instantiate(_player, transform);
    }
}
