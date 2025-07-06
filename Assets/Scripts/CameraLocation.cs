using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLocation : MonoBehaviour
{
    public Transform Transform;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = Transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
