using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] balls;
    private float spawnLeftLimit=-25;
    private float spawnRightLimit = -5;
    private float spawnPosY = 18;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, Random.Range(3,5));
    }

    void SpawnRandomBall()
    {
        Vector3 spawnPos = new Vector3(-3, spawnPosY, Random.Range(spawnLeftLimit,spawnRightLimit));

        Instantiate(balls[0], spawnPos, balls[0].transform.rotation);
    }
}
