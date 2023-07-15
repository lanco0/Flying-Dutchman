using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanBari : MonoBehaviour
{
    public float can;
    public float animasyonYavasligi;
    private float maxCan;
    private float gercekScale;

    void Start()
    {
        maxCan = can;
    }

    void Update()
    {
        gercekScale = can / maxCan;

        if (transform.localScale.x > gercekScale)
        {
            transform.localScale = new Vector3(transform.localScale.x - (transform.localScale.x - gercekScale) / animasyonYavasligi, transform.localScale.y, transform.localScale.z);
        }

        if (Input.GetKeyDown(KeyCode.A) && can>0 )
        {
            can -= 10;
        }
       
    }
}


