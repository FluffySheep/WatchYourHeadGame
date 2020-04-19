using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public Text timerText;

    float float_time = 0;
    int int_time = 0;

    private HighScoreCache highScoreText;

    void Start()
    {
        highScoreText = GameObject.FindWithTag("highscorecache").GetComponent<HighScoreCache>();
    }

    // Update is called once per frame
    void Update()
    {
        float_time += Time.deltaTime;
        int_time = (int)float_time;
        timerText.text = int_time.ToString();
    }

    public void SetHighScore()
    {
        highScoreText.SetHighScore(int_time);
    }
}
