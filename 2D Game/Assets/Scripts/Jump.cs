using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    [SerializeField]
    private float jumpVelocity;

    [SerializeField]
    private float fallMultiplyer;

    private bool isGrounded;

    [SerializeField]
    Rigidbody2D rb;

    private void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }


    void FixedUpdate () {
        //Debug.Log(isGrounded);
        //Debug.Log(GetComponent<Rigidbody2D>().velocity.y);

        //Increase gravity after apex of jump
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplyer - 1) * Time.deltaTime;
        }

        //When the screen is touched
        if (Input.touchCount > 0)
        {
            if (isGrounded)
            {
                rb.velocity = Vector2.up * jumpVelocity;
                isGrounded = false;
            }
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Grounded");
        isGrounded = true;
    }
}
