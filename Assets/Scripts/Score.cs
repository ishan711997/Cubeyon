
using UnityEngine;
using UnityEngine.UI;  //it allows right code for the interface

public class Score : MonoBehaviour
{
    public Transform plyr;
    public Text playerScor;   // Text is a unity component in inspector panel of text.
    
    void Update()
    {
        // Debug.Log(plyr.position.z);
        playerScor.text = plyr.position.z.ToString("Score: 0"); //ToString convert any datatype to string
    }
}
