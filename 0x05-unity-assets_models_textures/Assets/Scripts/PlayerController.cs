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
	[SerializeField] private Transform respawnPoint;
	
	// instantiation
	
	void Start () {
		controller = GetComponent<CharacterController>();
		Physics.IgnoreLayerCollision(0, 8);
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
	    //Detect when there is a collision
    void OnCollisionEnter(Collision collide)
    {
        //Output the name of the GameObject you collide with
        Debug.Log("I hit the GameObject : " + collide.gameObject.name);
    }
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Respawn")
		{
			// GetComponent<CharacterController>().enabled = false;
			transform.position = respawnPoint.transform.position;
			// GetComponent<CharacterController>().enabled = true;
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
