using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour
{
    public Text timerText;

    float float_time = 0;
    int int_time = 0;

    // Update is called once per frame
    void Update()
    {
        float_time += Time.deltaTime;
        int_time = (int)float_time;
        timerText.text = int_time.ToString();
    }
}
