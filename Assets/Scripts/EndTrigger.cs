
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Animator anim;
    public GameManager gameManager;
    public GameObject Player; // reference for stoping game player movement

    void OnTriggerEnter (Collider c){
        if(c.gameObject.tag == "Player"){
        gameManager.CompleteLevel();
        anim.SetBool("IsDancing", true);

    // for stoping game player movement
        Player.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
