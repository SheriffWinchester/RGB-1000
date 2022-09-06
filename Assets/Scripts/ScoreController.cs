using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreController : MonoBehaviour
{
    public int score = 100;

    public GameObject winMenu;
    public GameObject loseMenu;
    public TextMeshProUGUI scoreWinText;
    public TextMeshProUGUI scoreLoseText;

    void Start() 
    {
        scoreWinText = winMenu.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
        scoreLoseText = loseMenu.transform.GetChild(1).gameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {
        if (score >= 110)
        {   
            Time.timeScale = 0;
            winMenu.SetActive(true);
            scoreWinText.text = "Score " + score;

        }
        else if (score <= 0)
        {
            Time.timeScale = 0;
            loseMenu.SetActive(true);
            scoreLoseText.text = "Score 0";
            
        }
    }
}
