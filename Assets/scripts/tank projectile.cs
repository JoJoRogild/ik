/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankprojectile : MonoBehaviour
{
    public float timer = 15;
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0){
            Destroy(this.gameObject);
        }   
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "tank"){
            return;
        }
        if(col.tag == "Player"){
            col.GetComponent<playerscript>().hit();
            return;
        }
        Destroy(this.gameObject);
    }
    public void die(){
        Destroy(this.gameObject);
    }
}
*/