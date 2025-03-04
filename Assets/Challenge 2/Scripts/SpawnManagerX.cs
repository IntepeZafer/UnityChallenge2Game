using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    public float spawnLimitXLeft;
    public float spawnLimitXRight;
    public float spawnPosY;
    public float startDelay;
    public float spawnInterval;

    private void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    private void SpawnRandomBall()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        spawnInterval = Random.Range(3f, 5f);
        Invoke("SpawnRandomBall" , spawnInterval);
    }

}