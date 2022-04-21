using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float movespeed = 0.0f;
    void Update()
    {   
        float Stuff = Input.GetAxisRaw("Horizontal");
        transform.position = new Vector3(transform.position.x + Stuff*movespeed*Time.deltaTime, transform.position.y, transform.position.z);

    }
}

   
