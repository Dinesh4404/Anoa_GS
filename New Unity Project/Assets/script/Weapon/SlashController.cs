using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashController : WeaponController
{
    
    protected override void Start()
    {
        base.Start();
    }

    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedKnife = Instantiate(effectData.Prefab);
    }
}