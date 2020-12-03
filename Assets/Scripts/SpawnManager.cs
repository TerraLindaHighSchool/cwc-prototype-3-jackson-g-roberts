using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;

    private Vector3 obstacleSpawnPos = new Vector3(30.0f, 0.0f, 0.0f);

    private float startDelay = 2.0f;
    private float repeateRate = 2.0f;

    private PlayerController playerController;

    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeateRate);
    }

    void SpawnObstacle()
    {
        if (!playerController.gameOver) Instantiate(obstaclePrefab, obstacleSpawnPos, obstaclePrefab.transform.rotation);
    }
}
