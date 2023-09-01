using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController _playerControllerRef;
    public GameObject spawnPrefab;
    private Vector3 spawnPos = new Vector3(35, 0, 0);
    private float startDelay = 2f;
    private float repeatDelay = 2f;

    private void Start()
    {
        _playerControllerRef = FindObjectOfType<PlayerController>();
        InvokeRepeating("SpawnObstacle",startDelay,repeatDelay);
    }

    void SpawnObstacle()
    {
        if (_playerControllerRef.IsGameOver == false)
        {
            Instantiate(spawnPrefab, spawnPos, spawnPrefab.transform.rotation);
        }
    }
}
