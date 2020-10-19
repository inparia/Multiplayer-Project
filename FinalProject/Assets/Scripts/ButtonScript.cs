using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    public GameManager gameManager;

    public void ButtonNext()
    {
        SceneManager.LoadScene("ClientScene");
    }

    public void StopButton()
    {
        //set the name of the next scene by the string input
        if (gameManager.sum <= gameManager.GetGameNumber() + 3 && gameManager.sum >= gameManager.GetGameNumber() - 3)
        {
            SceneManager.LoadScene("WinScene");
        }
        else
        {
            SceneManager.LoadScene("LoseScene");
        }
    }

    public void RuleButton()
    {
        SceneManager.LoadScene("RulesScene");
    }
    public void SettingButton()
    {
        SceneManager.LoadScene("SettingsScene");
    }

    public void MainButton()
    {
        SceneManager.LoadScene("Start(Menu)State");
    }
}

