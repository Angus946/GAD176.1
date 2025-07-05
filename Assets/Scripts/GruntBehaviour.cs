using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GruntBehaviour : MonoBehaviour
{
    // target container for player transform, set in inspector
    public Transform target;

    //getting rigid body in case it gets used
    Rigidbody rb;

    // serialized speed for debug
    [SerializeField]
    float speed = 3.0f;

    public int damage = 10;

    [SerializeField]
    private bool hasAttacked = false;

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
            transform.forward = target.position - transform.position;
            GruntMovement();
        }
    }

    void GruntMovement()
    {
        // Null reference check
        if (target != null)
        {
            if (hasAttacked == false)
            {


                // new temp variable for using in the vector3 operation
                float moveSpeed = speed * Time.deltaTime;
                // changes the position to move toward the player at Movespeed
                transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed);
            }
            else
            {
                speed = 0;
                rb.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
    void GruntAttack()
    {
        if (target != null)
        {

            transform.localScale = new Vector3(3, 3, 3);
            transform.rotation = new Quaternion(+3, +3, +3, +3);
            hasAttacked = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (rb != null)
        {
            Debug.Log("collsion");
            if (collision.gameObject.CompareTag("Player"))
            {
                Debug.Log("is player");
                GruntAttack();
            }
            
        }
    }
}
