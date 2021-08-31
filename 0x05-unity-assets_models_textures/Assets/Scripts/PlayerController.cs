using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float jumpForce;
	public CharacterController controller;

	private Vector3 moveDirection;
	public float gravityScale;
	
	// instantiation
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	void Update (){
		// Player movement
		moveDirection =  new Vector3(Input.GetAxis("Horizontal") * speed, 0f, Input.GetAxis("Vertical") * speed);
		
		if (controller.isGrounded && Input.GetButtonDown("Jump"))
		{
			moveDirection.y = jumpForce;

		}

		moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
		controller.Move(moveDirection * Time.deltaTime);
		
		// esc key resets game
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
