using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankprojectile : MonoBehaviour
{
    public float timer = 15;
    private GameObject player;
    private Animator anim;
    private Rigidbody2D rb;
    void Start(){
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0){
            Destroy(this.gameObject);
        }   
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
        if(col.tag == "tank"){
            return;
        }
        if(col.tag == "Player"){
            player = col.gameObject;
            col.gameObject.GetComponent<playerscript>().hit();
            Debug.Log("this is inside the function idk ");
            GetComponent<Animator>().SetBool("Explote", true);
            Debug.Log("afteer");
            rb.velocity = new Vector3(0,0,0);
            //col.GetComponent<playerscript>().hit();
            return;
        }
        Destroy(this.gameObject);
    }
    public void die(){
        Destroy(this.gameObject);
    }
}
