using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    private float leftLimit = -25;
    private float bottomLimit=-5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z<leftLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y<bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
