using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jiaohuevent : MonoBehaviour
{
    Rigidbody rb3d;

    public void Start()
    {
        rb3d = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("jiaohu"))
        {

        }
    }
}
