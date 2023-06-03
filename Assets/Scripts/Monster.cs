using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    private float minY = -10f;

    [SerializeField]
    private float hp = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if (transform.position.y < minY)
        {
            Destroy(gameObject);
        }        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Bullet bullet = other.gameObject.GetComponent<Bullet>();
            hp -= bullet.damage;
            if(hp <= 0)
            {
                Destroy(gameObject);
            }
            Destroy(other.gameObject);
        }
    }
}
