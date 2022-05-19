using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tankSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject tank;
    public float initialTime = 0f;
    private float time;
    void Start(){
        time = 2;
    }
    void Update()
    {
        time -= Time.deltaTime;
        if(time < 0){
            time = initialTime;
            GameObject[] idk = GameObject.FindGameObjectsWithTag("tank");
            if(idk.Length >= 2){
                return;
            }
            GameObject test = Instantiate(tank, transform.position, transform.rotation);
            test.GetComponent<tank>().player = player;
        }
    }
}
