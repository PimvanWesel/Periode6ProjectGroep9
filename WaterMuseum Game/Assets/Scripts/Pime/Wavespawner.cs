using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavespawner : MonoBehaviour
{
    public static int enemiesAlive = 0;

    //public Wave[] waves;

    public Transform spawnpoint;

    public float timeBetweenWaves = 5f;
    public float countdown = 2f;

    private int waveIndex = 0;

    private void Start()
    {
    }

    private void Update()
    {
        if (enemiesAlive > 0)
        {
            return;
        }

        if (countdown <= 0f)
        {
        }
    }
}