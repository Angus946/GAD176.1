using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{

    public float playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        SettingHealth();
        playerHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DamageHealth(float amount)
    {
        playerHealth -= amount;
        if (playerHealth <= 0)
        {
            Die();
        }
    }
}
