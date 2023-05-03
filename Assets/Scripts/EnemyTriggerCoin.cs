using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemiesVault))]

public class EnemyTriggerCoin : MonoBehaviour
{
    [SerializeField] private Enemy _ghost;
    [SerializeField] private Enemy _skeleton;

    [SerializeField] private InstantiationPoint _statue;
    [SerializeField] private InstantiationPoint _gravestone;

    public void SpawnEnemies()
    {
        EnemiesVault enemies = EnemiesVault.GetStorage();

        enemies.Add(InstantiateEnemy(_skeleton, _gravestone));
        enemies.Add(InstantiateEnemy(_ghost, _statue));
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    private Enemy InstantiateEnemy(Enemy enemy, InstantiationPoint point)
    {
        float distanceFromCenter = 2.0f;
        float rotationAmount = 180;

        Vector2 position = point.transform.position;
        position.y += distanceFromCenter;

        Quaternion rotation = Quaternion.identity;
        rotation.y += rotationAmount;        

        return Instantiate(enemy, position, rotation);
    }
}
