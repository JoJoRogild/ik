using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class mastermind : MonoBehaviour
{
    public int flip1 = 0;
    public int flip2 = 0;
    public int flips = 0;
    string[] conver = { "empty", "H2", "S" };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flips == 2)
        {

            flips = 0;

            Thread.Sleep(2000);


            //enable alle boerns textobjecter
            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                Transform Childrens = gameObject.transform.GetChild(i);
                Childrens.gameObject.SetActive(true);
            }


        }
    }
}
