using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float fallMultiplyer = 1f;
    private float lowJumpMultiplyer = 2f;

    [SerializeField]
    Rigidbody2D rb;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    void Update () {
        if (Input.touchCount > 0)
        {
            //Test touch input
            //Debug.Log(Input.GetTouch(0).position);
        }
	}

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(speed, 0f);
        Debug.Log(Physics.Raycast(transform.position, Vector2.down, 0.5f));

        if (rb.velocity.y < 0)
        {
            //Debug.Log("Falling");
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplyer - 1) * Time.deltaTime;
        } else if(rb.velocity.y >= 0 && !Input.GetKeyDown (KeyCode.Space))
        {
            //Debug.Log("Low Jump");
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplyer - 1) * Time.deltaTime;
        }
    }

    private bool isGrounded()
    {
        return Physics.Raycast(transform.position, Vector2.down, 0.5f);
    }

}
