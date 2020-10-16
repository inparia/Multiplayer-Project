using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumClick : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public Text newText;
    private int rand_num;
    void Start()
    {
        button.onClick.AddListener(SetButton);
        rand_num = Random.Range(3, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetButton()
    {
        newText.text = rand_num.ToString();
    }
}
