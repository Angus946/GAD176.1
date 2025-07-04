using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    // max health is private because it only changes within the class
     int maxHealth;

    [SerializeField]
    public float health;

    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        SettingHealth();
    }

    // Update is called once per frame
    void Update()
    {
        DamageHealth();
    }

    public void DamageHealth ()
    {
        if (damage !=0)
        {
            health = health - (int)damage;
            if (health <= 0)
            {
                health = 0;
                Destroy(gameObject);
            }
        }
    }
    public void SettingHealth()
    {
        maxHealth = 100;
        health = (int)maxHealth;
    }
}
