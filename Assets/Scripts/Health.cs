using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField]
    // max health is private because it only changes within the class
    private int maxHealth;

    [SerializeField]
    float health;

    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        health = (float)maxHealth;
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
            health = health - (float)damage;
            if (health <= 0)
            {
                health = 0;
                Destroy(gameObject);
            }
        }
    }
}
