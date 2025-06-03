using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField]
    Rigidbody rb;
    [SerializeField]
    Transform playertrans;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playertrans = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
       playertrans.position = rb.position;
    }
}
