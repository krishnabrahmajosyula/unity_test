using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Reference to the player
    public Vector3 offset;   // Offset from the player to position the camera at a desired location
    public float followSpeed = 5f; // Speed at which the camera follows

    private void LateUpdate()
    {
        // Smoothly move the camera towards the player's position with an offset
        Vector3 desiredPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, desiredPosition, followSpeed * Time.deltaTime);

        // Keep the camera's rotation fixed
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
