using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rb;
    public float move;
    public string forwardKey;
    public string backKey;
    public string leftKey;
    public string rightKey;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        
        if(Input.GetKey(leftKey))
            rb.AddForce(Vector3.left*move);
        if (Input.GetKey(forwardKey))
            rb.AddForce(Vector3.forward*move);
        if (Input.GetKey(backKey))
            rb.AddForce(Vector3.back*move);
        if (Input.GetKey(rightKey))
            rb.AddForce(Vector3.right*move);
        if (Input.GetKey(KeyCode.Space))
        rb.AddForce(Vector3.up * move); 
    }
}
