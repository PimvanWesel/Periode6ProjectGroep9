using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation; 

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    void Start()
    {
        
    }

    void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("ocean"))
        {
            GameManager.oceanVervuiling = GameManager.oceanVervuiling + 100;
        }
    }
}
