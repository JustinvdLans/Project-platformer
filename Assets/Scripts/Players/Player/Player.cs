using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	//ExitTime UIT anders gaat t fout

	// Components koppelen aan script
	public Animator anim;
	public Rigidbody2D rb;

	public float speed;
	public float maxSpeed;
	public float jumpForce;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
  

    void FixedUpdate()
    {


    	// Walk buttons
		float h =  Input.GetAxis("Horizontal");

        rb.AddForce((Vector2.right * speed) * h);

        if(rb.velocity.x > maxSpeed)
        {
        	rb.velocity = new Vector2(maxSpeed, rb.velocity.y);
        }

        if(rb.velocity.x < -maxSpeed)
        {
        	rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);
        }
    }


     void Update()
    {
    	//jump function
    	if(Input.GetButtonDown("Jump"))
    	{
    		rb.AddForce(Vector2.up * jumpForce);
    	}

    	// Walk animations
        anim.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        if(Input.GetAxis("Horizontal") < -0.1f)
        {
        	transform.localScale = new Vector3(-0.7f,0.7f,1);
        }
        if(Input.GetAxis("Horizontal") > 0.1f)
        {
        	transform.localScale = new Vector3(0.7f,0.7f,1);
        }

    } 
        private void OnGUI()
    {
        GUI.Label(new Rect(10,10,100,20), "Score : " + points);
    }
    
}
