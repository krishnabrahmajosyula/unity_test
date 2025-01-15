using System.Collections;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject playerAnimator;
    [SerializeField] AudioSource collisionEffect;
    [SerializeField] GameObject mainCam;
    [SerializeField] GameObject fadeOut;


    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(CollisionEnd());
    }

    IEnumerator CollisionEnd()
    {
        collisionEffect.Play();
        thePlayer.GetComponent<PlayerMovement1>().enabled = false;
        playerAnimator.GetComponent<Animator>().Play("Stumble Backwards");
        mainCam.GetComponent<Animator>().Play("Camera Shake");
        yield return new WaitForSeconds(1);
        fadeOut.SetActive(true);

    }
}
