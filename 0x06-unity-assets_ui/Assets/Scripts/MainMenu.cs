using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public void LevelSelect(int level) {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + level);
    }
    public void Options() 
    {
        SceneManager.LoadScene(4);
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Exited");
    }
}
