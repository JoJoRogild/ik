using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistol : MonoBehaviour
{
    public GameObject projectile;
    public float speed = 20;

    void Update()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z);

        if (Input.GetKeyDown(KeyCode.Mouse0)){
            GameObject test = Instantiate(projectile, transform.position, transform.rotation);
            test.GetComponent<Rigidbody2D>().velocity =  diff*20;
        }
    }
}
