using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 1;
    
    void Update()
    {
        transform.RotateAround(transform.up, speed *Time.deltaTime);
    }
}
