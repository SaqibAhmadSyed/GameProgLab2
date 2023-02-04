using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationSpeed = 30f;
    public float forceAmount = 30f;

    public Rigidbody rb;

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
        rb.AddForce(transform.forward * forceAmount, ForceMode.Force);
    }
}
