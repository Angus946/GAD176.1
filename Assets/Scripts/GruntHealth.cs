using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GruntHealth : Health
{
    [SerializeField]
    float gruntHealth = Health.health;


    // Start is called before the first frame update
    void Start()
    {
        SettingHealth();
        gruntHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        DamageHealth();
    }
}
