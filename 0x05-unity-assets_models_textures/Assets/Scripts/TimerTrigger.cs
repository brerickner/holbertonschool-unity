using System.Collections;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    GameObject plyr;
    private void OnTriggerExit(Collider other)
	{
		plyr.GetComponent<Timer>().enabled = true;
	}
}
