using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun : MonoBehaviour
{

    public  bool[] Weapon = new bool[2];

    public UnityEvent FireGunHitScan;
    public UnityEvent FireGunProjectile;
    public static float damage = 10f;
    public static float range = 100f;
    public static float projectileSpeed;
    public static float shootCooldown = .4f;
    public static float activeCooldown;
    public Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GunShoot();
        }
    }
    
    void GunShoot()
    {
       if (Weapon[1] == true && Weapon[2] == false)
        {
            if(activeCooldown <= 0)
            {
                FireGunHitScan?.Invoke();
                activeCooldown = shootCooldown;
            }
          
            
        }
        else if (Weapon[1] == false && Weapon[2] == true)
        {
            FireGunProjectile?.Invoke();
            activeCooldown = shootCooldown;
        }
        activeCooldown -= Time.deltaTime;
    }
}
