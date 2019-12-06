using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerRike : MonoBehaviour
{
    [SerializeField] private GameObject Vangnet;
    private GameObject player1;
    private GameObject player2;
    private GameObject player3;
    private GameObject player4;

    private GameObject SpawnsPlayer1;
    private GameObject SpawnsPlayer2;
    private GameObject SpawnsPlayer3;
    private GameObject SpawnsPlayer4;

    private TouchPhase phase;

    private bool wheelSelected;
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

        SpawnsPlayer1 = GameObject.Find("Player 1 ObjectSpawns");
        SpawnsPlayer2 = GameObject.Find("Player 2 ObjectSpawns");
        SpawnsPlayer3 = GameObject.Find("Player 3 ObjectSpawns");
        SpawnsPlayer4 = GameObject.Find("Player 4 ObjectSpawns");
    }

    private void Update()
    {
        //for (int i = 0; i < Input.touchCount; i++)
        //{
        //foreach (Touch touch in Input.touches)
        //{
        //    Ray raycast = Camera.main.ScreenPointToRay(Input.touches[i].position);
        //    RaycastHit raycastHit;

        //    if (phase != TouchPhase.Stationary)
        //    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray raycast = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;

            if (Physics.Raycast(raycast, out raycastHit))
            {
                //Player 1 Touches
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
                }
                if (raycastHit.collider.name == "VangnetPlayer1")
                {
                    Instantiate(Vangnet, SpawnsPlayer1.transform.GetChild(0).transform.position, Quaternion.identity);
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (raycastHit.collider.name == "BeachCleanupPlayer1")
                {
                    Instantiate(Vangnet, SpawnsPlayer1.transform.GetChild(1).transform.position, Quaternion.identity);
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (raycastHit.collider.name == "FishingBoatsPlayer1")
                {
                    Instantiate(Vangnet, SpawnsPlayer1.transform.GetChild(2).transform.position, Quaternion.identity);
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (raycastHit.collider.name == "InterceptorPlayer1")
                {
                    Instantiate(Vangnet, SpawnsPlayer1.transform.GetChild(3).transform.position, Quaternion.identity);
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (raycastHit.collider.name == "ProjectCleanupPlayer1")
                {
                    Instantiate(Vangnet, SpawnsPlayer1.transform.GetChild(4).transform.position, Quaternion.identity);
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }

                //Player 2 Button
                if (raycastHit.collider.name == "Player 2")
                {
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