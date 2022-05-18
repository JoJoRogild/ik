using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planes : MonoBehaviour
{
    public float speed;
    public GameObject player;
    private Rigidbody2D rb;
    public int hp = 10;
    public GameObject projectile;
    public float timer = 5f;
    private float startTimer;
    void Start()
    {
        startTimer = timer;
        rb = GetComponent<Rigidbody2D>();        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x - transform.position.x < 0){
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else{
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
        timer -= Time.deltaTime;
        if(timer <= 0){
            Vector3 diff = player.transform.position - transform.position;
            diff.Normalize();
            float rot_z = Mathf.Atan2(player.transform.position.y-transform.position.y, player.transform.position.x - transform.position.x) * Mathf.Rad2Deg;
            GameObject test = Instantiate(projectile, transform.position, transform.rotation);
            test.transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
            test.GetComponent<Rigidbody2D>().velocity =  diff*20;
            timer = 10f;
        }
        if(hp <= 0){
            Destroy(this.gameObject);
        }

    }
    public void hit(){
        hp -= 1;
    }
}
