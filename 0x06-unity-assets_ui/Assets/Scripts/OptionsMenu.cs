using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{

    void Start() {
        string prevLevel = PlayerPrefs.GetString("lastLevel");
    }
    public void Back() {
        if (PlayerPrefs.HasKey("lastLevel")) 
        {
            SceneManager.LoadScene("lastLevel");
        } 
        //load default start scene
        else
        {
            SceneManager.LoadScene(0);
        }
    }
    public void Restarter()
	{
		SceneManager.LoadScene(0);
	}
    public void Menu()
	{
		SceneManager.LoadScene(0);
	}

}
