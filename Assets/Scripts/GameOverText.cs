using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    public Text gameOverText;

    string[] texts = {
        "Headshot!",
        "Better luck next time",
        "Tip: Protect your head",
        "You are an aspiring ninja",
        "Blocks are bad",
        "Keep it alive",
        "Don't quit your day job",
        "Don't blame your FPS",
        "Yes, it did hit your head"
    };
   

    void OnEnable()
    {
        gameOverText.text = texts[Random.Range(0, 5)];
    }
}
