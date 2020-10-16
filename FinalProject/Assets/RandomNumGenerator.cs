using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomNumGenerator : MonoBehaviour
{
    public Text newText;
    private int rand_num;
    // Start is called before the first frame update
    void Start()
    {

        rand_num = Random.Range(1, 100);

    }

    // Update is called once per frame
    void Update()
    {
        newText.text = rand_num.ToString();
    }
}
