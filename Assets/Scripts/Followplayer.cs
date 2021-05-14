
using UnityEngine;

public class Followplayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    void Update()
    {
        transform.position = player.position + offset;

    //  CAMERA follow only z-axis from below code
        // transform.position = new Vector3(0,3,player.transform.position.z - 5);
    }
}


