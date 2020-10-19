using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class GameManager : MonoBehaviour
{
    public int sum;
    int goalNumber;

    [Header("Buttons")]
    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject buttonThree;
    public GameObject sumNumber;
    public GameObject gameNumber;
    public GameObject loseWindow;
    // Start is called before the first frame update
    void Start()
    {
        sum = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if(sum > goalNumber)
        {
            //loseWindow.transform.position.x = 0.0f;
        }
       
    }

    public void AddUp(int number)
    {
        sum += number;
    }

    public void SetGameNumber(int gameNumber)
    {
        goalNumber = gameNumber;
    }



    public int GetGameNumber()
    {
        return goalNumber;
    }

}
