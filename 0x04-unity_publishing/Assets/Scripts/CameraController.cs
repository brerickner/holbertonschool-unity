using UnityEngine;

public class CameraController : MonoBehaviour
{

    /// Need position of the PlayerController
    public Transform player;
    // Update camera position ever fram
    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y + 15f, player.position.z - 5f);
    }
}
