using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameOver = false;
    public float restartDelay;
    public GameObject completeLevelUI;

    public void EndGame(){
        if(gameOver == false){
            gameOver = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void WinGame(){
        completeLevelUI.SetActive(true);
    }
}
