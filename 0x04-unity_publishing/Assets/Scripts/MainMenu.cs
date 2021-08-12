using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;

    
    /// <summary>
    /// Loads the maze scene when the Play button is pressed
    /// </summary>
    public void PlayMaze(){
        if (colorblindMode.isOn){
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else {
            trapMat.color = Color.red;
            goalMat.color = Color.green;
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    /// <summary>
    /// Closes game window when Quit button is pressed
    /// </summary>
    public void QuitMaze(){
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
