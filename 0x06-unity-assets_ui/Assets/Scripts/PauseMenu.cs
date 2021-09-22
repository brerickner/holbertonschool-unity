using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;    // Start is called before the first frame update
    void Start()
    {
        string prevLevel = PlayerPrefs.GetString("lastLevel");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Pause();
        }
    }
    public void Pause()
    {
        pauseMenu.gameObject.SetActive(true);
    }
    public void Menu()
	{
		SceneManager.LoadScene(0);
	}

    public void Restart()
	{
		SceneManager.LoadScene("prevLevel");
	}
}
