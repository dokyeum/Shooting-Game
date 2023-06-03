using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float bulletSpeed = 10f;

    public float damage = 1f;

    void Start()
    {
        Destroy(gameObject,1f);
    }

   
    void Update()
    {
        transform.position += Vector3.up * bulletSpeed * Time.deltaTime;
    }
}
