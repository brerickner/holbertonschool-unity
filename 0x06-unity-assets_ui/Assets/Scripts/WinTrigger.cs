using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject plyr;
    public GameObject winner;
    public Text timerText;

    private void OnTriggerEnter(Collider other)
	{
        plyr.GetComponent<Timer>().enabled = false;
        winner.SetActive(true);
        timerText.color = Color.green;
        timerText.fontSize = 75; 
	}
}
