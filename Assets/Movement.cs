using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float move_x = Input.GetAxis("Horizontal");
        float move_z = Input.GetAxis("Vertical");
        Vector3 Up = new Vector3(0f, rb.velocity.y, 0f);

        rb.velocity = (transform.forward * move_z + transform.right * move_x).normalized * movespeed + Up;



        //Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        //rb.velocity = movement * movespeed;
        //transform.LookAt(movement);
    }
}
