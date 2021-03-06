﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavespawner : MonoBehaviour
{
    public enum SpawnState { SPAWNING, WAINTING, COUNTING }

    [System.Serializable]
    public class Wave
    {
        public string name;
        public GameObject plastic1, plastic2, plastic3, plastic4;
        public int count;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;

    public Transform[] spawnPoints;

    public float timeBetweenWaves = 5f;
    private float waveCountdown;

    private float searchCountDown = 1f;

    private SpawnState state = SpawnState.COUNTING;

    private void Start()
    {
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("Geen spawnpunten toegewezen");
        }

        waveCountdown = timeBetweenWaves;
    }

    private void Update()
    {
        if (state == SpawnState.WAINTING)
        {
            if (!PlasticIsAlive())
            {
                WaveCompleted();
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    private void WaveCompleted()
    {
        Debug.Log("Wave completed");

        state = SpawnState.COUNTING;
        waveCountdown = timeBetweenWaves;

        if (nextWave + 1 > waves.Length - 1)
        {
            nextWave = 0;
            Debug.Log("Waves voltooit");
        }
        else
        {
            nextWave++;
        }

        nextWave++;
    }

    private bool PlasticIsAlive()
    {
        searchCountDown -= Time.deltaTime;
        if (searchCountDown <= 0)
        {
            searchCountDown = 1f;
        }
        return true;
    }

    private IEnumerator SpawnWave(Wave _wave)
    {
        Debug.Log("Spawning wave: " + _wave.name);
        state = SpawnState.SPAWNING;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnPlastic(_wave.plastic1);
            SpawnPlastic(_wave.plastic2);
            SpawnPlastic(_wave.plastic3);
            SpawnPlastic(_wave.plastic4);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.WAINTING;

        yield break;
    }

    private void SpawnPlastic(GameObject _enemy)
    {
        Debug.Log("Spawning plastic: " + _enemy.name);

        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, transform.position, transform.rotation);
    }
}