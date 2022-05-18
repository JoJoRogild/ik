using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerscript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    int isOnGround = 0;//0 er ikke p� jorden
    public float jumpFactor;
    public int health = 2; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(health <= 0){
            SceneManager.LoadScene("die");
        }
        //x movement
        int horizontalMov = (int)Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontalMov * Time.deltaTime * speed + rb.velocity.x, rb.velocity.y);
        if(horizontalMov < 0){
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, 180, this.transform.eulerAngles.z );
        }
        else if(horizontalMov > 0){
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, 0, this.transform.eulerAngles.z );
        }
        //y movement
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround == 1 || Input.GetAxis("Mouse ScrollWheel") < 0 && isOnGround == 1)
        {
            isOnGround = 0;
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
    public void hit(){
        health -= 1;
    }

}
