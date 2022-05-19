using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public float speed;
    public GameObject player;
    private Rigidbody2D rb;
    public int hp = 10;
    public GameObject projectile;
    public float initialTime;
    private float timer = 5f;

    void Start()
    {
        timer = initialTime;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(player.transform.position.x - transform.position.x < -0.1f){
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, 0, this.transform.eulerAngles.z );
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if(player.transform.position.x - transform.position.x > 0.1f){
            this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, 180, this.transform.eulerAngles.z );
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        else{
            rb.velocity = new Vector2(0, 0);
        }
        //float rot_z = Mathf.Atan2(player.transform.position.y-transform.position.y, player.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
        //transform.GetChild(0).rotation = Quaternion.Euler(0f, 0f, rot_z+90);
        timer -= Time.deltaTime;
        if(timer <= 0){
            Vector3 diff = player.transform.position - transform.position;
            diff.Normalize();
            float rot_z = Mathf.Atan2(player.transform.position.y-transform.position.y, player.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
            GameObject test = Instantiate(projectile, transform.position, transform.rotation);
            test.transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
            test.GetComponent<Rigidbody2D>().velocity =  diff*20;
            timer = initialTime;
        }
        if(hp <= 0){
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "Player"){
            coll.gameObject.GetComponent<playerscript>().hit();
            coll.gameObject.GetComponent<playerscript>().hit();
            coll.gameObject.GetComponent<playerscript>().hit();
            coll.gameObject.GetComponent<playerscript>().hit();
            coll.gameObject.GetComponent<playerscript>().hit();
        }
    }
    public void hit(){
        hp -= 1;
    }
}
