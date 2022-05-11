using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank : MonoBehaviour
{
    public float speed;
    public GameObject player;
    private Rigidbody2D rb;
    public int hp = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(player.transform.position.x - transform.position.x < 0){
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else{
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        float rot_z = Mathf.Atan2(player.transform.position.y-transform.position.y, player.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
        transform.GetChild(0).rotation = Quaternion.Euler(0f, 0f, rot_z+90);

        if(hp <= 0){
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "Player"){
            Destroy(coll.gameObject);
        }
    }
    public void hit(){
        hp -= 1;
    }
}
