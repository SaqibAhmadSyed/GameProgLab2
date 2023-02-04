using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int directionForce = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(-directionForce * Time.deltaTime, 0, 0);
            
        }
        if (Input.GetKey(KeyCode.D))
        {

            rb.AddForce(0, 0, directionForce * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(directionForce * Time.deltaTime, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(0, 0, -directionForce * Time.deltaTime);

        }

    }
}
