
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel(){
        AdManager.instance.ShowFullScreenAd();
        // UnityAdManager.Instance.DisplayVideoAd();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
