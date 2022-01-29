using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBillboard : MonoBehaviour
{
    public Transform camera;

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(camera);
        transform.rotation = camera.rotation;
    }
}
