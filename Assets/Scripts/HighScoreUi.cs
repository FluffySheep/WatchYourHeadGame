using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreUi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int highScore = GameObject.FindWithTag("highscorecache").GetComponent<HighScoreCache>().GetHighScore();
        gameObject.GetComponent<Text>().text = highScore.ToString();
    }
}
