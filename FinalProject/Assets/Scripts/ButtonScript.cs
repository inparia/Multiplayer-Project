using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{

    public void ButtonNext(string str)
    {
        //set the name of the next scene by the string input
        SceneManager.LoadScene(str);
    }
}
