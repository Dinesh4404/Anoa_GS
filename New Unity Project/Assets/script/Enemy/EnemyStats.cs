using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{

    public EnemyScriptableObject enemyData;

    float currentMoveSpeed;
    float currentHealth;
    float currentDamage;

    // Update is called once per frame
    void Awake()
    {
        currentMoveSpeed = enemyData.moveSpeed;
        currentHealth = enemyData.maxHealth;
        currentDamage = enemyData.Damage;
    }
    public void TakeDamage(float dmg)
    {
        currentHealth -= dmg;

        if(currentHealth <= 0)
        {
            Kill();
        }
    }
    public void Kill()
    {
        Destroy(gameObject);
    }

}
