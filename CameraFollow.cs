using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float smoothSpeed = 0.125f;
    private Vector3 velocity = Vector3.zero;
    
    private void LateUpdate() {
        Vector3 desiredPositon = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, desiredPositon, ref velocity, smoothSpeed);
    }
}
