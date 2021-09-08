using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float jumpForce;
	public CharacterController controller;

	private Vector3 moveDir;
	public float gravityScale;
	// [SerializeField] private Transform player;
	// [SerializeField] private Transform respawnPoint;
	
	// instantiation
	
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	void Update (){
		// Player movement
		moveDir =  new Vector3(Input.GetAxis("Horizontal") * speed, moveDir.y, Input.GetAxis("Vertical") * speed);
		
		if (controller.isGrounded)
		{
			moveDir.y = 0f;
			if(Input.GetButtonDown("Jump"))
			{
				moveDir.y = jumpForce;
			}
		}

		moveDir.y = moveDir.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
		controller.Move(moveDir * Time.deltaTime);
		
		// esc key resets game
		if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
		}
	}
	// void OnTriggerEnter(Collider other)
	// {
	// 	if (other.tag == "Respawn")
	// 	{
	// 		player.transform.position = respawnPoint.transform.position;
	// 	}
	// }

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
