﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Players : MonoBehaviour
{
    [SerializeField] private Text player1, player2, player3, player4;
    private int money;

    private void Start()
    {
    }

    private void Update()
    {
        HandleTouches();

        //if (name == "Player 1")
        //{
        //    money += 1;
        //    player1.text = "Geld: " + money;
        //}

        //if (name == "Player 2")
        //{
        //    money += 1;
        //    player2.text = "Geld: " + money;
        //}
        //if (name == "Player 3")
        //{
        //    money += 1;
        //    player3.text = "Geld: " + money;
        //}
        //if (name == "Player 4")
        //{
        //    money += 1;
        //    player4.text = "Geld: " + money;
        //}
    }

    private void HandleTouches()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            //Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);

            Ray raycast = Camera.main.ScreenPointToRay(Input.touches[i].position);
            RaycastHit raycastHit;
            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.name == "Player 1")
                {
                    Debug.Log("button 1 clicked");
                }
                if (raycastHit.collider.name == "Player 2")
                {
                    Debug.Log("button 2 clicked");
                }
                if (raycastHit.collider.name == "Player 3")
                {
                    Debug.Log("button 2 clicked");
                }
                if (raycastHit.collider.name == "Player 4")
                {
                    Debug.Log("button 2 clicked");
                }
            }
        }
    }
}