using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs; 
    private float spawnRangeX = 20f;
    private float spawnRangeZ = 20f;


    // Start is called before the first frame update
    void Start()
    {
       SpawnRandomBall();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void SpawnRandomBall() {
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
         int ballNumber = Random.Range(0, ballPrefabs.Length);
         Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);
         Invoke("SpawnRandomBall", Random.Range(2f,4f));

    }
}
