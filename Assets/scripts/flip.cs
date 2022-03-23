using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class flip : MonoBehaviour
{
    public Button yourButton;
    public GameObject textt;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        textt.SetActive(true);
    }
}