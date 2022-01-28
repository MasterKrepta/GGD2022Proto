using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMatcher : MonoBehaviour
{
    public float offset = 25;
    public bool isReal = true;
    public Transform linkedObject;
    // Start is called before the first frame update
    void Start()
    {
        if (linkedObject == null)
            return;

       //print("Layer" + this.gameObject.layer);


        if (isReal == true)
        {
            linkedObject.gameObject.layer = 7;
            linkedObject.position = this.transform.position+ new Vector3(-offset, 0);
            print("Layer" + this.gameObject.layer);
        }
        else
        {
            linkedObject.gameObject.layer = 6;
        }
    }


}
