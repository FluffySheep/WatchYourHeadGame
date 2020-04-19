using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject gameOver;

    private Rigidbody2D body;
    private Collider2D col;
    private float force = 2f;
    private GameTime gameTime;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        gameTime = GameObject.FindGameObjectWithTag("timer").GetComponent<GameTime>();
        col = gameObject.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            body.AddForce((mousePos - transform.position) * force, ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Finish"))
        {
            Time.timeScale = 0;
            gameTime.SetHighScore();
            gameOver.SetActive(true);
        }
    }
}
