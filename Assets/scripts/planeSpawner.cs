using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject plane;
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
            GameObject[] idk = GameObject.FindGameObjectsWithTag("plane");
            if(idk.Length >= 2){
                return;
            }
            GameObject test = Instantiate(plane, transform.position, transform.rotation);
            test.GetComponent<planes>().player = player;
        }
    }
}
