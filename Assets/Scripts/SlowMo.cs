using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo : MonoBehaviour
{
    private static float resetTime = 0.5f;
    private float curTime = resetTime;
    private bool slowMo = false;

    void Update()
    {
        if (slowMo)
        {
            curTime -= Time.deltaTime;
            if (curTime <= 0)
            {
                DisableSlowMo();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Finish"))
        {
            EnableSlowMo();
        }
    }

    void EnableSlowMo()
    {
        Debug.Log("Enable Slow Mo");
        curTime = resetTime;
        slowMo = true;
        Time.timeScale = 0.35f;
    }

    void DisableSlowMo()
    {
        Debug.Log("Disable Slow Mo");
        slowMo = false;
        curTime = resetTime;
        Time.timeScale = 1f;
    }
}
