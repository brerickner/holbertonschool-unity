using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle invertToggle;

    void Start() {

    }
    public void Back() 
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("lastLevel"));
    }
    public void Apply() {
        if (invertToggle.isOn == true)
        {
            PlayerPrefs.SetInt("isInverted", 1);
        }
        else
        {
            PlayerPrefs.SetInt("isInverted", 0);
        }
        Back();
    }
}
