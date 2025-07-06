using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gun : MonoBehaviour
{

    public UnityEvent Shoot;
    public static float damage = 10f;
    public static float range = 100f;
    public static float projectileSpeed = 1f;
    public static float shootCooldown = .4f;
    public static float activeCooldown = 1f;
    public Camera Camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   
}
