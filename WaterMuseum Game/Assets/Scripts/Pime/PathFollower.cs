using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    Node[] PathNode;
    public GameObject[] plastic;

    public float moveSpeed;
    float timer;
    int currentNode;

    public static Vector3 currentPositionHolder;

    void Start()
    {
        plastic = GameObject.FindGameObjectsWithTag("Plastic");
        PathNode = GetComponentsInChildren<Node>();
        CheckNode();
    }

    void Update()
    {
        Debug.Log(currentNode);
        timer += Time.deltaTime * moveSpeed;
        DrawLine();

        foreach (GameObject gameobj in plastic)
        {
            if (gameobj.transform.position != currentPositionHolder)
            {
                gameobj.transform.position = Vector3.Lerp(gameobj.transform.position, currentPositionHolder, timer);
            }
            else
            {
                currentNode++;
                CheckNode();
            }
        }
    }

    void CheckNode()
    {
        if (currentNode < PathNode.Length - 1)
        {
            timer = 0;
        }
        currentPositionHolder = PathNode[currentNode].transform.position;
    }

    void DrawLine()
    {
        for (int i = 0; i < PathNode.Length; i++)
        {
            if (i < PathNode.Length - 1)
            {
                Debug.DrawLine(PathNode[i].transform.position, PathNode[i + 1].transform.position, Color.red);
            }
        }
    }
}
