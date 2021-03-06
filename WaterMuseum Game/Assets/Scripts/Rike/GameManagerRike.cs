﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManagerRike : MonoBehaviour
{
    public static GameManagerRike Instance;
    [SerializeField] private GameObject Vangnet, BeachCleanup, FishingBoat, Interceptor, ProjectCleanup;
    private GameObject player1, player2, player3, player4;
    private GameObject ObjectToInstantiate1, ObjectToInstantiate2, ObjectToInstantiate3, ObjectToInstantiate4;
    private string selectedPadPlayer1, selectedPadPlayer2, selectedPadPlayer3, selectedPadPlayer4;
    public Image imageBar;

    private TouchPhase phase;

    private bool onPlayer1, onPlayer2, onPlayer3, onPlayer4;
    [HideInInspector] public bool ObjectSelectedPlayer1, ObjectSelectedPlayer2, ObjectSelectedPlayer3, ObjectSelectedPlayer4;
    public Transform projectSSpawn;

    private void Start()
    {
        Instance = this;
        player1 = GameObject.Find("Player 1");
        player2 = GameObject.Find("Player 2");
        player3 = GameObject.Find("Player 3");
        player4 = GameObject.Find("Player 4");
    }

    private void Update()
    {
        imageBar.rectTransform.localScale = new Vector3(GameManager.oceanVervuiling * 0.08f, imageBar.rectTransform.localScale.y, imageBar.rectTransform.localScale.z);
        //foreach (Touch touch in Input.touches)
        //{
        //////////////////////////////////////////////////Input met Touch
        //for (int i = 0; i < Input.touchCount; i++)
        //{
        //    Ray raycast = Camera.main.ScreenPointToRay(Input.touches[i].position);
        //    RaycastHit raycastHit;

        ////    if (phase != TouchPhase.Stationary)
        ////    {
        ////////////////////////////////////////////////////Input met Mouse
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
                    if (GameManager.moneyP1 >= GameManager.vangnetPrijs)
                    {
                        ObjectSelectedPlayer1 = true;
                        player1.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate1 = Vangnet;
                        onPlayer1 = false;
                        GameManager.moneyP1 = GameManager.moneyP1 - GameManager.vangnetPrijs;
                    }
                }
                if (raycastHit.collider.name == "BeachCleanupPlayer1")
                {
                    if (GameManager.moneyP1 >= GameManager.beachcleanerPrijs)
                    {
                        ObjectSelectedPlayer1 = true;
                        player1.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate1 = BeachCleanup;
                        onPlayer1 = false;
                        GameManager.moneyP1 = GameManager.moneyP1 - GameManager.beachcleanerPrijs;
                    }
                }
                if (raycastHit.collider.name == "FishingBoatsPlayer1")
                {
                    if (GameManager.moneyP1 >= GameManager.fishingbootPrijs)
                    {
                        ObjectSelectedPlayer1 = true;
                        player1.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate1 = FishingBoat;
                        onPlayer1 = false;
                        GameManager.moneyP1 = GameManager.moneyP1 - GameManager.fishingbootPrijs;
                    }
                }
                if (raycastHit.collider.name == "InterceptorPlayer1")
                {
                    if (GameManager.moneyP1 >= GameManager.interceptorPrijs)
                    {
                        ObjectSelectedPlayer1 = true;
                        ObjectToInstantiate1 = Interceptor;
                        player1.transform.GetChild(0).gameObject.SetActive(false);
                        onPlayer1 = false;
                        GameManager.moneyP1 = GameManager.moneyP1 - GameManager.interceptorPrijs;
                    }
                }
                if (raycastHit.collider.name == "ProjectCleanupPlayer1")
                {
                    if (GameManager.moneyP1 >= GameManager.projectcleanerPrijs)
                    {
                        player1.transform.GetChild(0).gameObject.SetActive(false);
                        Instantiate(ProjectCleanup, projectSSpawn.position, projectSSpawn.rotation);
                        onPlayer1 = false;
                        GameManager.moneyP1 = GameManager.moneyP1 - GameManager.projectcleanerPrijs;
                    }
                }
                if (ObjectSelectedPlayer1)
                {
                    GameObject padPlayer1;
                    selectedPadPlayer1 = raycastHit.collider.name;

                    if (selectedPadPlayer1.StartsWith("SelectField1"))
                    {
                        padPlayer1 = GameObject.Find(selectedPadPlayer1);
                        if (ObjectToInstantiate1 == Interceptor && selectedPadPlayer1.EndsWith("1") || selectedPadPlayer1.EndsWith("2"))
                        {
                            Instantiate(ObjectToInstantiate1, padPlayer1.transform.position, new Quaternion(0, -180, 0, 0));
                        }
                        else
                        {
                            Instantiate(ObjectToInstantiate1, padPlayer1.transform.position, Quaternion.identity);
                        }
                        ObjectSelectedPlayer1 = false;
                    }
                }

                //Player 2 Touches
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
                if (raycastHit.collider.name == "VangnetPlayer2")
                {
                    if (GameManager.moneyP2 >= GameManager.vangnetPrijs)
                    {
                        ObjectSelectedPlayer2 = true;
                        player2.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate2 = Vangnet;
                        onPlayer2 = false;
                        GameManager.moneyP2 = GameManager.moneyP2 - GameManager.vangnetPrijs;
                    }
                }
                if (raycastHit.collider.name == "BeachCleanupPlayer2")
                {
                    if (GameManager.moneyP2 >= GameManager.beachcleanerPrijs)
                    {
                        ObjectSelectedPlayer2 = true;
                        player2.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate2 = BeachCleanup;
                        onPlayer2 = false;
                        GameManager.moneyP2 = GameManager.moneyP2 - GameManager.beachcleanerPrijs;
                    }
                }
                if (raycastHit.collider.name == "FishingBoatsPlayer2")
                {
                    if (GameManager.moneyP2 >= GameManager.fishingbootPrijs)
                    {
                        ObjectSelectedPlayer2 = true;
                        player2.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate2 = FishingBoat;
                        onPlayer2 = false;
                        GameManager.moneyP2 = GameManager.moneyP2 - GameManager.fishingbootPrijs;
                    }
                }
                if (raycastHit.collider.name == "InterceptorPlayer2")
                {
                    if (GameManager.moneyP2 >= GameManager.interceptorPrijs)
                    {
                        ObjectSelectedPlayer2 = true;
                        player2.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate2 = Interceptor;
                        onPlayer2 = false;
                        GameManager.moneyP2 = GameManager.moneyP2 - GameManager.interceptorPrijs;
                    }
                }
                if (raycastHit.collider.name == "ProjectCleanupPlayer2")
                {
                    if (GameManager.moneyP2 >= GameManager.projectcleanerPrijs)
                    {
                        player2.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate2 = ProjectCleanup;
                        Instantiate(ProjectCleanup, projectSSpawn.position, projectSSpawn.rotation);
                        onPlayer2 = false;
                        GameManager.moneyP2 = GameManager.moneyP2 - GameManager.projectcleanerPrijs;
                    }
                }
                if (ObjectSelectedPlayer2)
                {
                    GameObject padPlayer2;
                    selectedPadPlayer2 = raycastHit.collider.name;

                    if (selectedPadPlayer2.StartsWith("SelectField2"))
                    {
                        padPlayer2 = GameObject.Find(selectedPadPlayer2);
                        if (ObjectToInstantiate2 == Interceptor && selectedPadPlayer2.EndsWith("1") || selectedPadPlayer2.EndsWith("2"))
                        {
                            Instantiate(ObjectToInstantiate2, padPlayer2.transform.position, new Quaternion(0, -180, 0, 0));
                        }
                        else
                        {
                            Instantiate(ObjectToInstantiate2, padPlayer2.transform.position, Quaternion.identity);
                        }
                        ObjectSelectedPlayer2 = false;
                    }
                }

                //Player 3 Touches
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
                if (raycastHit.collider.name == "VangnetPlayer3")
                {
                    if (GameManager.moneyP3 >= GameManager.vangnetPrijs)
                    {
                        ObjectSelectedPlayer3 = true;
                        player3.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate3 = Vangnet;
                        onPlayer3 = false;
                        GameManager.moneyP3 = GameManager.moneyP3 - GameManager.vangnetPrijs;
                    }
                }
                if (raycastHit.collider.name == "BeachCleanupPlayer3")
                {
                    if (GameManager.moneyP3 >= GameManager.beachcleanerPrijs)
                    {
                        ObjectSelectedPlayer3 = true;
                        player3.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate3 = BeachCleanup;
                        onPlayer3 = false;
                        GameManager.moneyP3 = GameManager.moneyP3 - GameManager.beachcleanerPrijs;
                    }
                }
                if (raycastHit.collider.name == "FishingBoatsPlayer3")
                {
                    if (GameManager.moneyP3 >= GameManager.fishingbootPrijs)
                    {
                        ObjectSelectedPlayer3 = true;
                        player3.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate3 = FishingBoat;
                        onPlayer3 = false;
                        GameManager.moneyP3 = GameManager.moneyP3 - GameManager.fishingbootPrijs;
                    }
                }
                if (raycastHit.collider.name == "InterceptorPlayer3")
                {
                    if (GameManager.moneyP3 >= GameManager.interceptorPrijs)
                    {
                        ObjectSelectedPlayer3 = true;
                        player3.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate3 = Interceptor;
                        onPlayer3 = false;
                        GameManager.moneyP3 = GameManager.moneyP3 - GameManager.interceptorPrijs;
                    }
                }
                if (raycastHit.collider.name == "ProjectCleanupPlayer3")
                {
                    if (GameManager.moneyP3 >= GameManager.projectcleanerPrijs)
                    {
                        player3.transform.GetChild(0).gameObject.SetActive(false);
                        Instantiate(ProjectCleanup, projectSSpawn.position, projectSSpawn.rotation);
                        onPlayer3 = false;
                        GameManager.moneyP3 = GameManager.moneyP3 - GameManager.projectcleanerPrijs;
                    }
                }
                if (ObjectSelectedPlayer3)
                {
                    GameObject padPlayer3;
                    selectedPadPlayer3 = raycastHit.collider.name;

                    if (selectedPadPlayer3.StartsWith("SelectField3"))
                    {
                        padPlayer3 = GameObject.Find(selectedPadPlayer3);
                        if (ObjectToInstantiate3 == Interceptor && selectedPadPlayer3.EndsWith("1") || selectedPadPlayer3.EndsWith("2") || selectedPadPlayer3.EndsWith("3"))
                        {
                            Instantiate(ObjectToInstantiate3, padPlayer3.transform.position, new Quaternion(0, -180, 0, 0));
                        }
                        else
                        {
                            Instantiate(ObjectToInstantiate3, padPlayer3.transform.position, Quaternion.identity);
                        }
                        ObjectSelectedPlayer3 = false;
                    }
                }

                //Player 4 Touches
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
                if (raycastHit.collider.name == "VangnetPlayer4")
                {
                    if (GameManager.moneyP4 >= GameManager.vangnetPrijs)
                    {
                        ObjectSelectedPlayer4 = true;
                        player4.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate4 = Vangnet;
                        onPlayer4 = false;
                        GameManager.moneyP4 = GameManager.moneyP4 - GameManager.vangnetPrijs;
                    }
                }
                if (raycastHit.collider.name == "BeachCleanupPlayer4")
                {
                    if (GameManager.moneyP4 >= GameManager.beachcleanerPrijs)
                    {
                        ObjectSelectedPlayer4 = true;
                        player4.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate4 = BeachCleanup;
                        onPlayer4 = false;
                        GameManager.moneyP4 = GameManager.moneyP4 - GameManager.beachcleanerPrijs;
                    }
                }
                if (raycastHit.collider.name == "FishingBoatsPlayer4")
                {
                    if (GameManager.moneyP4 >= GameManager.fishingbootPrijs)
                    {
                        ObjectSelectedPlayer4 = true;
                        player4.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate4 = FishingBoat;
                        onPlayer4 = false;
                        GameManager.moneyP4 = GameManager.moneyP4 - GameManager.fishingbootPrijs;
                    }
                }
                if (raycastHit.collider.name == "InterceptorPlayer4")
                {
                    if (GameManager.moneyP4 >= GameManager.interceptorPrijs)
                    {
                        ObjectSelectedPlayer4 = true;
                        player4.transform.GetChild(0).gameObject.SetActive(false);
                        ObjectToInstantiate4 = Interceptor;
                        onPlayer4 = false;
                        GameManager.moneyP4 = GameManager.moneyP4 - GameManager.interceptorPrijs;
                    }
                }
                if (raycastHit.collider.name == "ProjectCleanupPlayer4")
                {
                    if (GameManager.moneyP4 >= GameManager.projectcleanerPrijs)
                    {
                        player4.transform.GetChild(0).gameObject.SetActive(false);
                        onPlayer4 = false;
                        Instantiate(ProjectCleanup, projectSSpawn.position, projectSSpawn.rotation);
                        GameManager.moneyP4 = GameManager.moneyP4 - GameManager.projectcleanerPrijs;
                    }
                }
                if (ObjectSelectedPlayer4)
                {
                    GameObject padPlayer4;
                    selectedPadPlayer4 = raycastHit.collider.name;

                    if (selectedPadPlayer4.StartsWith("SelectField4"))
                    {
                        padPlayer4 = GameObject.Find(selectedPadPlayer4);
                        if (ObjectToInstantiate4 == Interceptor && selectedPadPlayer4.EndsWith("1") || selectedPadPlayer4.EndsWith("2") || selectedPadPlayer4.EndsWith("3"))
                            Instantiate(ObjectToInstantiate4, padPlayer4.transform.position, new Quaternion(0, -180, 0, 0));
                        else
                            Instantiate(ObjectToInstantiate4, padPlayer4.transform.position, Quaternion.identity);

                        ObjectSelectedPlayer4 = false;
                    }
                }
            }
        }
    }
}