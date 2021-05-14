
using UnityEngine;
using UnityEngine.SceneManagement; // include SceneManagement for Scene related work like reload, restart and manymore.

public class GameManager : MonoBehaviour
{
    public float restartDelay = 2f;  // not used in game
    // public GameObject RewardUIBtn;


    public GameObject CompleteLevelUI;

    public void CompleteLevel(){
        CompleteLevelUI.SetActive(true);  // for active panal
        }
    // // *************not is used****************
    //     public void GameReward(){
    //         Invoke("RewardGame", restartDelay);
    //     }
    //     public void RewardGame(){
    //         RewardUIBtn.SetActive(true);
    //     }
    // *****************************************
    public void EndGame(){   //use public keyword before void, otherwise we cant access into playercollision script
        Debug.Log("GAME OVER");
        Invoke("Restart", restartDelay); //Invoke fn for changing time in sec
        // "Restart" is not a string it is a function which is define below        
    }    

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
// SceneManager.LoadScene(...)        -> *** LOAD THE SCENE OF THE GIVEN NAME***
// SceneManager.GetActiveScene().name -> *** RETURN THE NAME OF CURRENT SCENE***
    }


}
