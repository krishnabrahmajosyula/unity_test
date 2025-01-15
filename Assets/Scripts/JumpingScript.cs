using UnityEngine;

public class JumpingScript : MonoBehaviour
{
    [SerializeField] GameObject playerAnim;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] Rigidbody playerRigidBody;
    private bool isOnGround=true;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isOnGround)
        {
            playerAnim.GetComponent<Animator>().Play("Jump");
            playerRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
