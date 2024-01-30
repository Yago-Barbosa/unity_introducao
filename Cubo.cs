using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour
{
    public float force = 20;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.AddForce(new Vector3(horizontal, 0 , vertical) * force);
    }
    private void OnCollisionEnter(Collision collision)
    {
        OutroCubo outroCubo = collision.gameObject.GetComponent<OutroCubo>();
        if(outroCubo != null)
        {
            outroCubo.health -= 10;
        }
    }
}
