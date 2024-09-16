using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollider : MonoBehaviour
{
    public int playerStrength;
    private string tagString = "Vazio";
    //private List <GameObject> enemiesInRange;
    private GameObject closeEnemy;

    private void Update()
    {
        Attack();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        tagString = collision.gameObject.tag;

        if (tagString.Contains("Enemy"))
        {
            closeEnemy = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        tagString = "Vazio";
        closeEnemy = null;
    }

    void Attack()
    {
        if (this.gameObject.name == "AttackColliderOne")
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("JOGADOR 1 ATACOU: " + tagString);

                if (closeEnemy != null)
                {
                    EnemyStats stats = closeEnemy.GetComponent<EnemyStats>();
                    stats.TakingDamage(playerStrength);
                }
            }
        }
        else if (this.gameObject.name == "AttackColliderTwo")
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Debug.Log("JOGADOR 2 ATACOU: " + tagString);

                if (closeEnemy != null)
                {
                    EnemyStats stats = closeEnemy.GetComponent<EnemyStats>();
                    stats.TakingDamage(playerStrength);
                }
            }
        }
    }
}
