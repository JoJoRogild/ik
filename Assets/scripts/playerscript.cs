using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    int isOnGround = 0;//0 er ikke p� jorden
    public float jumpFactor;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //x movement
        int horizontalMov = (int)Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalMov * Time.deltaTime * speed + rb.velocity.x, rb.velocity.y);
        //y movement
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == 1)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y + jumpFactor);
        }
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.transform.tag == "ground")
        {
            isOnGround = 1;
        }
    }
    private void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.transform.tag == "ground")
        {
            isOnGround = 0;
        }
    }
}
