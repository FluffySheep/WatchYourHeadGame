using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour
{
    public void OnPlayAgain()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void OnPlayStart()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}