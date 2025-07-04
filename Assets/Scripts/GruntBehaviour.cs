using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GruntBehaviour : MonoBehaviour
{
    // target container for player transform, set in inspector
    public Transform target;

    //getting rigid body in case it gets used
    Rigidbody rb;

    // serialized speed for debug
    [SerializeField]
    float speed = 1.0f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        // Null reference check for player position target
        if (target != null)
        {
            transform.LookAt(target.position);
            GruntMovement();
        }
    }

    void GruntMovement()
    {
        // Null reference check
        if (target != null)
        {
            // new temp variable for using in the vector3 operation
            float moveSpeed = speed * Time.deltaTime;
            // changes the position to move toward the player at Movespeed
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed);
        }
    }
}
