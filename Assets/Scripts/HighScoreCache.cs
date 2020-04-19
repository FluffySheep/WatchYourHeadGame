using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreCache : MonoBehaviour
{
    int highScore = 0;

    private Text highScoreText;
    void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    public void SetHighScore(int highScore)
    {
        if (highScore > this.highScore)
        {
            this.highScore = highScore;
            highScoreText.text = highScore.ToString();
        }
    }

    public int GetHighScore()
    {
        return highScore;
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        highScoreText = GameObject.FindWithTag("highscoreui").GetComponent<Text>();
    }
}
