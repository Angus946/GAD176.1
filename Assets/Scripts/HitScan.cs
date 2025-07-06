using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScan : MonoBehaviour
{
    float rangeHS = Gun.range;
    float damageHS = Gun.damage;
    public Transform transformHS;
    public Camera cam;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transformHS != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Shoot();
            }
        }
    }

    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transformHS.position, transformHS.forward, out hit, rangeHS) )
        {
            Debug.Log(hit.transform.name);
        }
       
    }
}
