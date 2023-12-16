using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header ("Weapon Stats")]
    public EffectScriptableObject effectData;
    float currentCooldown; 
    
    protected virtual void Start()
    {
        currentCooldown = effectData.CooldownDuration;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        currentCooldown -= Time.deltaTime;
        if(currentCooldown <=0f )
        {
            Attack();
        }
    }

    protected virtual void Attack()
    {
        currentCooldown = effectData.CooldownDuration;
    }
}
