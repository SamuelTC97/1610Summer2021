using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    
    // Created new Vector3 to orient camera to that position and then attached the player (plane) to the GameObject plane in the main camera
    private Vector3 offset = new Vector3(13, 1, 1);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Changed to LateUpdate to avoid stutter
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
