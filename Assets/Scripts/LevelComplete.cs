using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public string levelName; //  other way is annoying
    public void LoadNextLeve(){
        SceneManager.LoadScene(levelName);
    }
}
