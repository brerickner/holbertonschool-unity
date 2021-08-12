using UnityEngine;

public class Rotator : MonoBehaviour
{
    // change rotation to 45 on x
    public float rotation = 45f;
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime, 0, 0);
    }
}
