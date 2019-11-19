using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Players : MonoBehaviour
{
    [SerializeField] private Text player1, player2, player3, player4;
    private float money;

    private void Start()
    {
    }

    private void Update()
    {
        if (name == "Player 1")
        {
            money += 0.1f * Time.deltaTime;
            player1.text = "Geld: " + money;
        }

        if (name == "Player 2")
        {
            money += 0.2f * Time.deltaTime;
            player2.text = "Geld: " + money;
        }
        if (name == "Player 3")
        {
            money += 0.3f * Time.deltaTime;
            player3.text = "Geld: " + money;
        }
        if (name == "Player 4")
        {
            money += 0.4f * Time.deltaTime;
            player4.text = "Geld: " + money;
        }
    }
}