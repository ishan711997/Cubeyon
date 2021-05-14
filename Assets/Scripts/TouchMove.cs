using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    public Rigidbody rb;
    public float sidewaysForce = 100f;
    private float screenwidth;
    // Start is called before the first frame update
    void Start()
    {
        screenwidth = Screen.width/2;
    }

    // Update is called once per frame
    void Update()
    {
        TouchControl();
    }

    void TouchControl(){
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.position.x < screenwidth){
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }else if(-touch.position.x < screenwidth){
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
    }
}
