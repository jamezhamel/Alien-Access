using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUI : MonoBehaviour
{
    protected float maxHealth, currentHealth;

    public void InitializeHealth(float health)
    {
        maxHealth = health;
        currentHealth = health;
    }

    public void SetHealth(float newhealth)
    {
        currentHealth = newhealth;

    }
}