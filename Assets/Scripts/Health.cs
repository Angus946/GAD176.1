using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    // max health is private because it only changes within the class
     int maxHealth;

    [SerializeField]
    public static float health;

    [SerializeField]
    public static float damage;
    
    // Start is called before the first frame update
    void Start()
    {
        SettingHealth();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("this is the current damage " + damage);
    }

    public void DamageHealth ()
    {
        health = health - damage;
        if (health <= 0)
        {
            health = 0;
           
        }
    }
    public void SettingHealth()
    {
        maxHealth = 100;
        health = (int)maxHealth;
    }

    
}
