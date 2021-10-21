using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class CutsceneController : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject player;
    public GameObject timerCanvas;
    public GameObject introCam;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Called by animator
    void afterIntro()
    {
        mainCam.SetActive(true);
        player.GetComponent<PlayerController>().enabled = true;
        timerCanvas.SetActive(true);
        introCam.SetActive(false);
    }
}
