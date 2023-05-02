using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    [SerializeField] private ChestOpener _chest;
    [SerializeField] private RoadLampLight _lamp;

    private static int _enemiesCount = 2;

    private Enemy[] _enemies = new Enemy[_enemiesCount];

    public void Activate()
    {
        _chest.Activate();
        _lamp.On();
        DestroyEnemies();
    }

    private void DestroyEnemies()
    {
        _enemies = FindObjectsOfType<Enemy>();

        foreach (Enemy enemy in _enemies)
            enemy.Destroy();
    }
}
