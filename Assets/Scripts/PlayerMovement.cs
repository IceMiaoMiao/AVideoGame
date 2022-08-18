using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;

    public float sidewaysForce = 500f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0);
            
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0);
            
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,forwardForce*Time.deltaTime,ForceMode.VelocityChange);
            
        }
    }
}
