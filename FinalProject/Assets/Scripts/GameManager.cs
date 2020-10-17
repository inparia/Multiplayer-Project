using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class GameManager : MonoBehaviour
{
    public int sum;
    [Header("Buttons")]
    public GameObject buttonOne;
    public GameObject buttonTwo;
    public GameObject buttonThree;
    public GameObject sumNumber;
    // Start is called before the first frame update
    void Start()
    {
        sum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    public void AddUp(int number)
    {
        sum += number;
    }



}
