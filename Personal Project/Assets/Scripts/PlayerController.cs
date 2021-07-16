using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    private Rigidbody playerRb;
    private float speed = 3f;
    private float zBound = 22.5f;
    private float xBound = 24f;
    private float edgeBounce = 100.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ConstrainPlayerMovement();
    }

    void MovePlayer()
    {  
        //Get axis' for input and add force to player rigidbody to make player move
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * speed * horizontalInput);
        playerRb.AddForce(Vector3.forward * speed * verticalInput);
    }

    void ConstrainPlayerMovement()
    {
        //Keeps player inside the boundaries of the game and apply opposing force to prevent the need to accelerate for long periods of time in opposing direction to unstick from wall
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
            playerRb.AddForce(Vector3.forward * edgeBounce);
        }
        
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
            playerRb.AddForce(Vector3.back * edgeBounce);
        }
        
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
            playerRb.AddForce(Vector3.right * edgeBounce);
        }
        
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
            playerRb.AddForce(Vector3.left * edgeBounce);
        }
    }
}
