using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    // public AdManager adManager;    

    // void Start(){
    //     adManager = GameObject.Find().GetComponent<AdManager>();
    //     adManager.instance.RequestBanner();
    // }

    public void StartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // adManager.instance.HideBanner();
    }
}
