using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCenterAndDestroy : MonoBehaviour
{
	private GameObject floor;
	private Rigidbody enemyRb;
	private float speed = 2;
	public float zLimit;
	public float xLimit;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
		floor = GameObject.Find("Floor");
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 lookDirection = (floor.transform.position - transform.position).normalized;
	   enemyRb.AddForce(lookDirection * speed);

	   if (transform.position.z < zLimit && transform.position.x < xLimit)
	   {
		   Destroy(gameObject);
	   }
    }
}
