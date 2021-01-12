using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notCrossing : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    public float force = 50;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.CompareTag("Boundary"))
            rb.AddForce(0, 0, 0);
    }


}
