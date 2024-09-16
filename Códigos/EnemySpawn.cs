using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Vector2[] enemiesPos;

    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            GameObject newEnemy = Instantiate(enemyPrefab, enemiesPos[i], Quaternion.identity);

            EnemyStats stats = newEnemy.GetComponent<EnemyStats>();
            stats.health = 5;
            stats.strength = 1;
        }
    }
}
