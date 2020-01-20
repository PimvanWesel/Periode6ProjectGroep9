using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 5;
    private float distanceTravelled;

    public GameObject[] PadsPlayer1;
    public GameObject[] PadsPlayer2;
    public GameObject[] PadsPlayer3;
    public GameObject[] PadsPlayer4;

    private int chanceOfStranding;

    private Vector3 _BoxSize;
    private Vector3 _BoxOfset;

    private void Start()
    {
        _BoxSize = transform.localScale;
        chanceOfStranding = Random.Range(0, 3);

        PadsPlayer1 = GameObject.FindGameObjectsWithTag("PadPlayer1");
        PadsPlayer2 = GameObject.FindGameObjectsWithTag("PadPlayer2");
        PadsPlayer3 = GameObject.FindGameObjectsWithTag("PadPlayer3");
        PadsPlayer4 = GameObject.FindGameObjectsWithTag("PadPlayer4");
    }

    private void Update()
    {
        distanceTravelled += speed * Time.deltaTime;
        transform.Rotate(0, 2, 0);

        if (tag == "PlasticPlayer1")
        {
            foreach (GameObject pPads in PadsPlayer1)
            {
                if (Vector3.Distance(transform.position, pPads.transform.position) < 20)
                {
                    transform.position = Vector3.MoveTowards(transform.position, pPads.transform.position, 0.08f);
                }
                else
                {
                    transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
                }
            }
        }

        if (tag == "PlasticPlayer2")
        {
            foreach (GameObject pPads in PadsPlayer2)
            {
                if (Vector3.Distance(transform.position, pPads.transform.position) < 20)
                {
                    transform.position = Vector3.MoveTowards(transform.position, pPads.transform.position, 0.08f);
                }
                else
                {
                    transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
                }
            }
        }

        if (tag == "PlasticPlayer3")
        {
            foreach (GameObject pPads in PadsPlayer3)
            {
                if (Vector3.Distance(transform.position, pPads.transform.position) < 5)
                {
                }
            }
        }

        if (tag == "PlasticPlayer4")
        {
            foreach (GameObject pPads in PadsPlayer4)
            {
                if (Vector3.Distance(transform.position, pPads.transform.position) < 5)
                {
                }
            }
        }

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

            if (Colliders[i].CompareTag("VangNet"))
            {
                Destroy(gameObject);
            }
        }
    }
}