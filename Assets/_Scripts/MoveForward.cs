using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = 5f;
    public float lifetime = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.position +=  transform.forward * speed *Time.deltaTime; 
        
        Destroy(gameObject, lifetime);
    }
}
