using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;


    [SerializeField]
    private GameObject Bullet;

    [SerializeField]
    private Transform Launch;

    [SerializeField]
    private float Bulletinterval = 0.05f;
    private float ShotTime = 0f;
    

    void Start()
    {

    }


    void Update()
    {
        Vector3 move = new Vector3(speed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= move;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += move;
        }

            shooting();
        
     
    }

    void shooting()
    {
        if(Time.time - ShotTime > Bulletinterval) {
            Instantiate(Bullet, Launch.transform.position, Quaternion.identity);
            ShotTime = Time.time;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Monster")
        {
            GameManager.instance.SetGameOver();
            Destroy(gameObject);
        }
    }

}
