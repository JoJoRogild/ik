using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    float timer = 15;

    void Update(){
        timer -= Time.deltaTime;
        if(timer < 0){
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "enemy"){
            Destroy(col.gameObject);
        }
        else if(col.tag == "tank"){
            col.gameObject.GetComponent<tank>().hit();
        }
        Destroy(this.gameObject);
    }
}
