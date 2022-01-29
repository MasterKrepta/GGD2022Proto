using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBillboard : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(transform);
        transform.rotation = transform.rotation;
    }
}
