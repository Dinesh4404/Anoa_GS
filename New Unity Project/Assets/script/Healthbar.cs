using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Healthbar : MonoBehaviour
{
    public float maxHealth = 100f;
    public float health;
    public TextMeshProUGUI healthText;

    void Start()
    {
        health = maxHealth;
    }

    void takeDamage(float damage)
    {
        health -= damage;
    }
    public void updateHealth(float value)
    {
        health = value;
        healthText.SetText(health.ToString("0"));
    }
    
}