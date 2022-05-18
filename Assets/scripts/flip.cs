using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class flip : MonoBehaviour
{
    public Button yourButton;
    public Button resetButton;
    public GameObject textt;
    public string flip1;
    public string flip2;
    public GameObject mastermind;
    public Text MyText;
    public string tesg;


    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        Button btn2 = resetButton.gameObject.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnReset);
        tesg = transform.GetChild(0).GetComponent<Text>().text;
    }



    void Update()
    {
        
    }

    void TaskOnClick()
    {
        if (transform.parent.gameObject == mastermind)
        {
            textt.SetActive(true);
            string flipy1 = mastermind.GetComponent<mastermind>().flip1.ToString();
            string flipy2 = mastermind.GetComponent<mastermind>().flip2.ToString();

            Debug.Log(flipy1 + flipy2);

            if (flipy1 == "null")
            {
                mastermind.GetComponent<mastermind>().flip1 = tesg;
            }
            else if (flipy2 == "null")
            {
                mastermind.GetComponent<mastermind>().flip2 = tesg;
            }
        }
        
    }

    void TaskOnReset()
    {
        textt.SetActive(false);
        transform.SetParent(mastermind.transform, true);
    }
}