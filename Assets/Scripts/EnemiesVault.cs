using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class EnemiesVault : MonoBehaviour
{
    private static EnemiesVault Storage;

    private List<Enemy> _enemies = new List<Enemy>();

    private void Start()
    {
        Storage = GetComponent<EnemiesVault>();
    }

    public static EnemiesVault GetStorage()
    {
        return Storage;
    }

    public void Add(Enemy enemy)
    {
        _enemies.Add(enemy);
    }

    public void Destroy()
    {
        if (_enemies != null)
            foreach (Enemy enemy in _enemies)
                enemy.Destroy();

        _enemies.Clear();
    }
}
