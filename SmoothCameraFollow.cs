using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    // Primary target to follow, to get his position.
    [SerializeField] private Transform target;
    // Quantity to offset the position of the camera before moving it
    [SerializeField] private Vector3 offset;
    // Time to correct the offset to the right camera position
    [SerializeField] private float smoothSpeed = 0.125f;
    private Vector3 velocity = Vector3.zero;
    
    private void LateUpdate() {
        // Defines the desired amount of space between the real position and the desired position
        Vector3 desiredPositon = target.position + offset;
        // Transform the position using the SmoothDamp() function to get a smooth effect based on the parameters given.
        transform.position = Vector3.SmoothDamp(transform.position, desiredPositon, ref velocity, smoothSpeed);
    }
}
