using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rigid;

    public float CarForce = 5000f;

    void FixedUpdate()
    {
        rigid.AddForce(0, 0, -CarForce);
    }

     // Disable the behaviour when it becomes invisible...
    void OnBecameInvisible()
    {
        Destroy(gameObject);
        Debug.Log("has invisible");
    }

    // stop car
    void OnCollisionEnter(Collision other) {
        if(other.collider.tag == "Player"){
            Destroy(rigid);
        }
    }

    // ...and enable it again when it becomes visible.
    // void OnBecameVisible()
    // {
    //     Destroy(gameObject);
    //     Debug.Log("has visible");

    // }
}


   
