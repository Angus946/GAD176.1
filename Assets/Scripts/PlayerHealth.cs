using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{

    float playerHealth = Health.health;

    // Start is called before the first frame update
    void Start()
    {
        SettingHealth();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
       
    
    }
}
