
using UnityEngine;

public class PlyaerCollision : MonoBehaviour
{
    public PlayerMovement Movement;

// Create a variable and access the animator
    public Animator anim;

    // - OnCollisionEnter()  function method- when a cube(anything) collide with another cube
   void OnCollisionEnter (Collision CollisionInfo){  //Collision is pre-define CollisionInfo is user-define any name
       if(CollisionInfo.collider.tag == "Obstacal"){ //Obstacal is in the "" form because it is string
            Debug.Log("Player Hit the enemy");

        //  This is for animation is falling is a parameter name and 
            anim.SetBool("IsDown", true);

        //**********************************************************
            
            // GetComponent<PlayerMovement>().enabled = false;    same result as below one line
            Movement.enabled = false;  

//  call a interstitial ad
        AdManager.instance.ShowFullScreenAd();

        //FindObjectOfType<>() is a method
            FindObjectOfType<GameManager>().EndGame();
    
       }
   }
}
