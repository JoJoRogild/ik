using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class mastermind : MonoBehaviour
{
    public string flip1 = "null";
    public string flip2 = "null";
    public int flips = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flip1 != "null" && flip2 != "null")
        {

            print(flip1 + " + " + flip2);

            //enable alle boerns textobjecter
            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                Transform Childrens = gameObject.transform.GetChild(i);
                Childrens.gameObject.SetActive(true);
            }

            Thread.Sleep(2000);

            flip1 = "null";
            flip2 = "null";
        }
    }
}
