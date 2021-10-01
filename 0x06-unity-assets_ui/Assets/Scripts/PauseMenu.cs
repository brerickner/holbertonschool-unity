using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;    
    private bool paused;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            paused = !paused;
            if (!paused)
            {
                Pause();
            }
            if (paused)
            {
                Resume();
            }   
        }
    }
    public void Pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }
    public void Menu()
	{
		SceneManager.LoadScene(0);
	}

    public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
    public void Resume()
	{
		// if (paused == 1)
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        // paused = 0;
	}
    public void Options()
	{
		SceneManager.LoadScene(4);
	}
}
