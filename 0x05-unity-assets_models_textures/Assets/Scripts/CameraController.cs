using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float rotateSpeed = 5f;
    public Transform pivot;
    public bool useOffsetValues;

    // Start is called before the first frame update
    void Start() {
        if (!useOffsetValues)
        {
            // target = GetComponent<Transform>();
            offset = target.position - transform.position;
        }

        pivot.transform.position = target.transform.position;
        pivot.transform.parent = target.transform;
    }
    
    // Update is called once per frame
    void Update()
    {
        // Get the x position of the mouse and rotate the target
        // rotate player within the world
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        // Get Y position of mouse and rotate pivot
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        pivot.Rotate(-vertical, 0, 0);

        // Move camera based on the current rotation of the target and the original offset
        float desiredYAngle = target.eulerAngles.y;
        float desiredXAngle = pivot.eulerAngles.x;

        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        transform.position = target.position - (rotation * offset);

        // transform.position = target.position - offset;
        transform.LookAt(target);
    }
}
