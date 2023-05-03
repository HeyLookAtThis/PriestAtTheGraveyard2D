using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EnemiesVault))]

public class Enemy : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
