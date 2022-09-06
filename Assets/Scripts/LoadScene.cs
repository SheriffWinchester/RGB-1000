using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoadScene: MonoBehaviour
{
    public void LoadPlayScene() 
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync("Menu");
    }
}
