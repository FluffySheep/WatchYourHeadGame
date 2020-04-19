using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnObj;

    private static float maxSpawnTime = 4f; // seconds
    private float currentSpawnTime = 0f;

    void Update()
    {

        currentSpawnTime -= Time.deltaTime;
        if (currentSpawnTime <= 0)
        {
            Spawn();
            currentSpawnTime = maxSpawnTime;
        }
    }

    void Spawn()
    {
        GameObject go = Instantiate<GameObject>(spawnObj, transform.position, Quaternion.identity);
        Rigidbody2D rb = go.GetComponent<Rigidbody2D>();

        rb.AddForce(Random.insideUnitCircle * Random.Range(1,15), ForceMode2D.Impulse);
        rb.AddTorque(Random.Range(1, 15));
    }
}
