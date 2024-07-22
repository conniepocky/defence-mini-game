using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // use rigidbody to move player

    public Rigidbody2D rb;

    [SerializeField]
    private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // get input from player

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal, vertical) * 50;

        if (Input.GetMouseButtonDown(0))
        {
            // spawn bullet and have it move forwards 

            Instantiate(bullet, transform.position, transform.rotation);
    
        }

    }
}
