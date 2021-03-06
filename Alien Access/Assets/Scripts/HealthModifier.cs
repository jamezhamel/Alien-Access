using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof (Collider))]
public class HealthModifier : MonoBehaviour
{
    public float deltaHp;
    
    void OnTriggerStay(Collider other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.ModifyHealth(deltaHp * Time.deltaTime);
        }
    }
}
