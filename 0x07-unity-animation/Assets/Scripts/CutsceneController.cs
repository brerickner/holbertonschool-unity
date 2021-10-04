using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class CutsceneController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject playerController;
    public GameObject timerCanvas;
    public GameObject cutSceneController;

    // Start is called before the first frame update
    void Start()
    {
        Object[] allObjects = Object.FindObjectsOfType<GameObject>();

        foreach (GameObject go in allObjects)
        {
            Debug.Log(go + " is an active object " + go.GetInstanceID());
        }
        
        
    //     mainCamera = playerController.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;
    }

    // Called by animator
    void StartGame()
    {
        mainCamera.SetActive(true);
        mainCamera.GetComponent<CameraController>().enabled = true;
        playerController.SetActive(true);
        playerController.GetComponent<PlayerController>().enabled = true;
        cutSceneController.SetActive(false);
    }
}
