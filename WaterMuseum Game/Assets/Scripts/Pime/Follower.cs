using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    private float distanceTravelled;

    private Vector3 _BoxSize;
    private Vector3 _BoxOfset;

    private void Start()
    {
        _BoxSize = transform.localScale;
    }

    private void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.Rotate(0, 2, 0);
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);

        CollisionCheck();
    }

    private void CollisionCheck()
    {
        Collider[] Colliders = Physics.OverlapBox(transform.position + _BoxOfset, _BoxSize);
        for (int i = 0; i < Colliders.Length; i++)
        {
            if (Colliders[i].CompareTag("ocean"))
            {
                GameManager.oceanVervuiling = GameManager.oceanVervuiling + 100;
                Destroy(gameObject);
            }
        }
    }

}