using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public Rigidbody2D rb;

    private Vector2 computerLocation;
    // Start is called before the first frame update
    void Start()
    {
        computerLocation = new Vector2(0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //move towards computer

        Vector2 direction = computerLocation - rb.position;

        direction.Normalize();

        rb.velocity = direction * 50;

        // check for collision


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "computer")
        {
            Manager.health -= 10;
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "bullet") {
            Destroy(gameObject);
        }
    }
}
