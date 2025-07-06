using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLocation : MonoBehaviour
{
    public Transform Transform;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Transform.position + new Vector3((float)-0.2, 0.5f, 0);
        transform.rotation = Transform.rotation;
    }
}
