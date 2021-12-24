using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{


    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        { GetComponent<Rigidbody>().velocity = Vector3.left * 1.2f; }

        if (Input.GetKey(KeyCode.D))
        { GetComponent<Rigidbody>().velocity = Vector3.right * 1.2f; }

        if (Input.GetKey(KeyCode.W))
        { GetComponent<Rigidbody>().velocity = Vector3.forward * 1.2f; }

        if (Input.GetKey(KeyCode.S))
        { GetComponent<Rigidbody>().velocity = Vector3.back * 1.2f; }
        
    }
}
