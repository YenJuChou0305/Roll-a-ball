using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zz : MonoBehaviour 
{

    //public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * 10);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("hit"))
        {
            other.gameObject.SetActive(false);
        }
    }

}
