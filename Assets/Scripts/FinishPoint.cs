using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemiesVault))]

public class FinishPoint : MonoBehaviour
{
    [SerializeField] private ChestOpener _chest;
    [SerializeField] private RoadLampLight _lamp;

    private EnemiesVault _enemies;

    private void Start()
    {
        _enemies = EnemiesVault.GetStorage();
    }

    public void Activate()
    {
        _chest.Activate();
        _lamp.On();
        _enemies.Destroy();
    }
}
