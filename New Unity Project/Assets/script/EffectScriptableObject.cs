using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EffectScriptableObject", menuName ="ScriptableObjects/Effect")]
public class EffectScriptableObject : ScriptableObject
{
    public GameObject prefab;
    public float damage;
    public float speed;
    public float cooldownDuration;
    public int pierce;
}
