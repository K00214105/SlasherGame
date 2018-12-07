using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class Movement : MonoBehaviour {
    public float sphereRadius;
    private Vector3 increment = new Vector3(0, 0, .03f);
   
    // Use this for initialization
    void Start () {
       
    }

    

    // Update is called once per frame
    void Update () {
        this.transform.Translate(increment);

       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Human"))
        {
            other.gameObject.SetActive(false);

        }

        if (Physics.CheckSphere(transform.position, sphereRadius))
        {
            gameObject.SetActive(false);

        }


    }
}
