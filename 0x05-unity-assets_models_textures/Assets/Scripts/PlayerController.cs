using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed = 80.0f;
	private Rigidbody rigid;

	
	/// Gets rigidbody at start for player
	void Start() {
		rigid = GetComponent<Rigidbody>();
	}

	/// Use fixed when working with physics
	void FixedUpdate()
	{
		/// Gets horizontal position when key "a" or "d"/right-left arrowkeys
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		Vector3 move = new Vector3(horizontal, 0.0f, vertical);
		
		/// Takes the vector3 move and applies it to direction of addforce and * by speed
		rigid.AddForce(move * speed);
		// transform.position += move * speed;
	}
	
	/// Player health expiration
	void Update (){
		if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
	}

	/// <summary>
	/// Delays scene reload for 3 seconds
	/// </summary>
	/// <param name="seconds">Delay in seconds</param>
	/// <returns>Reset scene</returns>
	IEnumerator LoadScene(float seconds){
		yield return new WaitForSeconds(seconds);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}
