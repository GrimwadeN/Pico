using UnityEngine;
using System.Collections;

public class ConstantMovement : MonoBehaviour {

   
    [Header("Players Speed")]
    public float speed = 4;
    public float jumpHeight = 2;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = transform.GetComponent<Rigidbody2D>();
	}

	void FixedUpdate(){
		rb.AddForce(Vector3.right * speed);

	}

	// Update is called once per frame
	void Update () {

        //rb.velocity = new Vector3(speed * Time.deltaTime, 0, 0);
		if(Input.GetButtonDown("Jump"))
		{
			rb.velocity = new Vector3(rb.velocity.x, jumpHeight );
			//rb.AddForce(Vector3.up * jumpHeight, ForceMode.VelocityChange);
		}
	}
}
