using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyButtonBehaviour : MonoBehaviour
{
    public GameObject inputFiled;
    public GameObject ipDisplay;
    // Start is called before the first frame update
    public void ButtonPressed()
    {
        
        //GameObject.Find("ClientScene").GetComponent<NetworkClient>().serverIP = inputFiled.GetComponent<CommitNewIPScript>().temptext.ToString();
        Debug.Log("Apply presed");
        //Debug.Log(inputFiled.GetComponent<CommitNewIPScript>().temptext);
    }
}
