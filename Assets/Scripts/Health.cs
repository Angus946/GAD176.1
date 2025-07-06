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

    
    
    // Start is called before the first frame update
    void Start()
    {
        SettingHealth();
    }

    // Update is called once per frame
    void Update()
    {

    }

   
    public void SettingHealth()
    {
        maxHealth = 100;
        health = (int)maxHealth;
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
