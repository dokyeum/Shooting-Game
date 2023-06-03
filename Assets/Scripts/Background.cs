using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private float BackgroundSpeed = 5f;

    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.position += Vector3.down * BackgroundSpeed * Time.deltaTime;
        if (transform.position.y <= -10)
        {
            transform.position += new Vector3(0, 20f, 0);
        }
    }
}
