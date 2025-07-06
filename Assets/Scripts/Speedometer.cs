using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using TMPro.EditorUtilities;

public class Speedometer : MonoBehaviour
{

    public Rigidbody rb;

    public string speed;

    public TMP_Text speedText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        speed = rb.velocity.magnitude.ToString();
        speedText.text = speed;
    }
}
