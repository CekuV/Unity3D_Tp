using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBall : MonoBehaviour
{
    
    public GameObject co;

    private void Start()
    {
        InvokeRepeating("RndmBall", 0f, 0.5f);
    }

    void RndmBall()
    {
        Vector3 posit = new Vector3(
            Random.Range(-4,5),
            Random.Range(1,4),
            Random.Range(3,13));

        Instantiate(co, posit, transform.rotation);
    }
    

}
