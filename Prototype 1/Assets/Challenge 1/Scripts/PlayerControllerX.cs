using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Created GameObject propeller in order to make the propeller spin without creating a separate script
    public GameObject propeller;
    
    // Changed to private after picking the speed I wanted it set at
    private float speed = 18.0f;
    
    // Changed to private after settling on keeping the rotationSpeed it was set at
    private float rotationSpeed = 100.0f;
    
    // Changed to private
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // tilt the plane up/down based on up/down arrow keys or the W and S keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);
        
        // rotate the propeller around its Z axis. Not sure if it would have been better to make a private float that was set to 15 instead of inserting it here.
        propeller.transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * 15);
    }
}
