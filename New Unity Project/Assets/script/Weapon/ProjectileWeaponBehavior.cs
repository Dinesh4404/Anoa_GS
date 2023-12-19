using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileWeaponBehavior : MonoBehaviour
{
    public EffectScriptableObject effectData;
    
    public float destroyAfterSeconds;

    protected float currentDamage;
    protected float currentSpeed;
    protected float currentCooldownDuration;
    protected int currentPierce;

    void Awake()
    {
        currentDamage = effectData.Damage;
        currentSpeed = effectData.Speed;
        currentCooldownDuration = effectData.CooldownDuration;
        currentPierce = effectData.Pierce;
    }
    
    protected virtual void Start()
    {
        Destroy(gameObject, destroyAfterSeconds); 
    }

    protected virtual void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Enemy"))
        {
            EnemyStats enemy = col.GetComponent<EnemyStats>();
            enemy.TakeDamage(currentDamage);
        }
    }

}