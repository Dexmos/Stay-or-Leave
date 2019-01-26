using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExempleClass : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            rb.AddForce(transform.forward * 1000);
        }
    }
}