using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<EnemyTriggerCoin>(out EnemyTriggerCoin preciousCoin))
        {
            preciousCoin.SpawnEnemies();
            preciousCoin.Destroy();
        }

        if(collision.TryGetComponent<Coin>(out Coin coin))
            coin.Destroy();

        if (collision.TryGetComponent<FinishPoint>(out FinishPoint finish))
            finish.Activate();
    }
}
