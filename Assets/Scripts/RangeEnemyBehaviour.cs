using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeEnemyBehaviour : MonoBehaviour
{
    // target container for player transform, set in inspector
    public Transform target;
    public Transform barrel;
    //getting rigid body in case it gets used
    Rigidbody rb;

    // serialized speed for debug
    [SerializeField]
    float speed = 0f;

    public float damage = 30;

    [SerializeField]
    private bool hasAttacked = false;

    float reload;
    float activeReload;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        reload = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyAttack();
    }
    private void FixedUpdate()
    {
        // Null reference check for player position target
        if (target != null)
        {
            transform.forward = target.position - transform.position;
            EnemyMovement();
        }
    }

    void EnemyMovement()
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
                hasAttacked = true;
                if (reload > 0)
                {
                    reload = reload - Time.deltaTime;
                }
                else if (reload < 0)
                {
                    hasAttacked = false;
                     reload = 5;
                }
            }
        }
    }
    void EnemyAttack()
    {
        if (target != null)
        {
            if (hasAttacked == false)
            {
                RaycastHit hit;
                if (Physics.Raycast(barrel.position, barrel.forward, out hit, 100f))
                {
                    Debug.Log(hit.transform.name);
                    PlayerHealth player = hit.transform.GetComponent<PlayerHealth>();
                    if (player != null)
                    {
                        player.DamageHealth(damage);
                        hasAttacked = true;
                    }
                }
                transform.rotation = new Quaternion(5, 5, 5, 5);

            }
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
                EnemyAttack();
            }

        }
    }
}
