using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CraftingTableTitel : MonoBehaviour
{
    public GameObject mastermind;
    public string smstr;
    public GameObject me;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        List<string> sometext = mastermind.GetComponent<mastermind>().matches;
        smstr = "";
        for (int i = 0; i < sometext.ToArray().Length; i++)
        {
            smstr += sometext[i];
        }

        me.GetComponent<Text>().text = smstr;

        if (smstr == "H2SO4")
        {
            print("win");
        }
    }
}
