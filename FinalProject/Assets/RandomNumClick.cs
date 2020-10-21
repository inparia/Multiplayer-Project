using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class RandomNumClick : MonoBehaviour
{
    // Start is called before the first frame update
    public Button button;
    public Text newText;
    public int rand_num;
    public GameManager gameManager;
    void Start()
    {
        rand_num = Random.Range(1, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetRandom()
    {
        newText.text = rand_num.ToString();
        button.interactable = false;
        gameManager.AddUp(rand_num);
    }



}
