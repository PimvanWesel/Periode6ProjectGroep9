using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerRike : MonoBehaviour
{
    private GameObject player1;
    private GameObject player2;
    private GameObject player3;
    private GameObject player4;
    private TouchPhase phase;

    private bool onPlayer1;
    private bool onPlayer2;
    private bool onPlayer3;
    private bool onPlayer4;

    private void Start()
    {
        player1 = GameObject.Find("Player 1");
        player2 = GameObject.Find("Player 2");
        player3 = GameObject.Find("Player 3");
        player4 = GameObject.Find("Player 4");
    }

    private void Update()
    {
        //for (int i = 0; i < Input.touchCount; i++)
        //{
        //    //foreach (Touch touch in Input.touches)
        //    //{
        //    Ray raycast = Camera.main.ScreenPointToRay(Input.touches[i].position);
        //    RaycastHit raycastHit;

        //    if (Physics.Raycast(raycast, out raycastHit))
        //    {
        //        if (raycastHit.collider.name == "Player 1")
        //        {
        //            player1.transform.GetChild(0).gameObject.SetActive(true);
        //            Debug.Log("button 1 clicked");
        //        }
        //        else
        //        {
        //            player1.transform.GetChild(0).gameObject.SetActive(false);
        //            Debug.Log("button 1 released");
        //        }
        //        if (raycastHit.collider.name == "Player 2")
        //        {
        //            Debug.Log("button 2 clicked");
        //            player2.GetComponent<Renderer>().material.color = Color.black;
        //        }
        //        else
        //        {
        //            Debug.Log("button 2 released");
        //            player2.GetComponent<Renderer>().material.color = Color.yellow;
        //        }
        //        if (raycastHit.collider.name == "Player 3")
        //        {
        //            Debug.Log("button 3 clicked");
        //            player3.GetComponent<Renderer>().material.color = Color.black;
        //        }
        //        else
        //        {
        //            Debug.Log("button 3 released");
        //            player3.GetComponent<Renderer>().material.color = Color.yellow;
        //        }
        //        if (raycastHit.collider.name == "Player 4")
        //        {
        //            Debug.Log("button 4 clicked");
        //            player4.GetComponent<Renderer>().material.color = Color.black;
        //        }
        //        else
        //        {
        //            Debug.Log("button 4 Released");
        //            player4.GetComponent<Renderer>().material.color = Color.yellow;
        //        }
        //    }
        //}

        Debug.LogError(onPlayer1);
        if (Input.GetMouseButtonUp(0))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(raycast, out raycastHit))
            {
                if (raycastHit.collider.name == "Player 1")
                {
                    if (onPlayer1 == true)
                    {
                        player1.transform.GetChild(0).gameObject.SetActive(false);
                        onPlayer1 = false;
                    }
                    else
                    {
                        player1.transform.GetChild(0).gameObject.SetActive(true);

                        onPlayer1 = true;
                    }

                    Debug.Log("button 1 clicked");
                }

                if (raycastHit.collider.name == "Player 2")
                {
                    Debug.Log("button 2 clicked");
                    if (onPlayer2 == true)
                    {
                        player2.transform.GetChild(0).gameObject.SetActive(false);
                        onPlayer2 = false;
                    }
                    else
                    {
                        player2.transform.GetChild(0).gameObject.SetActive(true);

                        onPlayer2 = true;
                    }
                }

                if (raycastHit.collider.name == "Player 3")
                {
                    Debug.Log("button 3 clicked");
                    if (onPlayer3 == true)
                    {
                        player3.transform.GetChild(0).gameObject.SetActive(false);
                        onPlayer3 = false;
                    }
                    else
                    {
                        player3.transform.GetChild(0).gameObject.SetActive(true);

                        onPlayer3 = true;
                    }
                }

                if (raycastHit.collider.name == "Player 4")
                {
                    Debug.Log("button 4 clicked");
                    if (onPlayer4 == true)
                    {
                        player4.transform.GetChild(0).gameObject.SetActive(false);
                        onPlayer4 = false;
                    }
                    else
                    {
                        player4.transform.GetChild(0).gameObject.SetActive(true);

                        onPlayer4 = true;
                    }
                }
            }
        }
    }
}