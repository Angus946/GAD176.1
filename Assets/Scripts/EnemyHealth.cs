using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField]
    float enemyHealth = Health.health;


    // Start is called before the first frame update
    void Start()
    {
        SettingHealth();
        enemyHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DamageHealth(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }

    }
}
