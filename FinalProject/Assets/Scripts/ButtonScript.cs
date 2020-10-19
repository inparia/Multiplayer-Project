using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    public GameManager gameManager;
    public void ButtonNext(string str)
    {
        //set the name of the next scene by the string input
        if(gameManager.sum <= gameManager.GetGameNumber() + 3 && gameManager.sum >= gameManager.GetGameNumber() - 3)
        {
            SceneManager.LoadScene("WinScene");
        }
        else
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
