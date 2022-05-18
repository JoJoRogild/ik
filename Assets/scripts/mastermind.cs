using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class mastermind : MonoBehaviour
{
    public Button yourButton;
    public string flip1 = "null";
    public string flip2 = "null";
    public int flips = 0;
    public List<string> matches = new List<string>();
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(2);

        for (int i = 0; i < transform.childCount; i++)
        {

            Transform Childrens = gameObject.transform.GetChild(i);
            Childrens.GetChild(0).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (flip1 != "null" && flip2 != "null")
        {

            print(flip1 + " + " + flip2);

            if (flip1 == flip2)
            {
                matches.Add(flip1);
                for (int i = 0; i < transform.childCount; i++)
                {
                    Debug.Log(i);
                    Transform Childrens = gameObject.transform.GetChild(i).transform;
                    Debug.Log(Childrens.gameObject.name + " " + Childrens.GetChild(0).gameObject.name);
                    if (Childrens.GetChild(0).gameObject.active)
                    {
                        print("hi");
                        //Childrens.transform.parent = canvas.transform;
                        Childrens.transform.SetParent(canvas.transform, true);
                        i -= 1;
                    }
                }

            }
            else
            {
                StartCoroutine(ExampleCoroutine());
            }

            flip1 = "null";
            flip2 = "null";
        }
    }

    void TaskOnClick()
    {
        matches.Clear();
    }
}
