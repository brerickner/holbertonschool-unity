using System.Collections;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
	public GameObject plyr;
    private void OnTriggerExit(Collider other)
	{
		plyr.GetComponent<Timer>().enabled = true;
	}
}
