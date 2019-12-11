using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerRike : MonoBehaviour
{
    public static GameManagerRike Instance;
    [SerializeField] private GameObject Vangnet;
    private GameObject player1, player2, player3, player4;
    private string selectedObjectPlayer1;
    public string selectedPadPlayer1, selectedPadPlayer2, selectedPadPlayer3, selectedPadPlayer4;

    private TouchPhase phase;

    private bool wheelSelected;
    private bool onPlayer1, onPlayer2, onPlayer3, onPlayer4;
    [HideInInspector] public bool ObjectSelectedPlayer1, ObjectSelectedPlayer2, ObjectSelectedPlayer3, ObjectSelectedPlayer4;

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
                    ObjectSelectedPlayer1 = true;
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (raycastHit.collider.name == "BeachCleanupPlayer1")
                {
                    ObjectSelectedPlayer1 = true;
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (raycastHit.collider.name == "FishingBoatsPlayer1")
                {
                    ObjectSelectedPlayer1 = true;
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (raycastHit.collider.name == "InterceptorPlayer1")
                {
                    ObjectSelectedPlayer1 = true;
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (raycastHit.collider.name == "ProjectCleanupPlayer1")
                {
                    ObjectSelectedPlayer1 = true;
                    player1.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer1 = false;
                }
                if (ObjectSelectedPlayer1)
                {
                    GameObject padPlayer1;
                    selectedPadPlayer1 = raycastHit.collider.name;

                    if (selectedPadPlayer1.StartsWith("SelectField1"))
                    {
                        padPlayer1 = GameObject.Find(selectedPadPlayer1);
                        Instantiate(Vangnet, padPlayer1.transform.position, Quaternion.identity);
                        ObjectSelectedPlayer1 = false;
                    }
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
                if (raycastHit.collider.name == "VangnetPlayer2")
                {
                    ObjectSelectedPlayer2 = true;
                    player2.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer2 = false;
                }
                if (raycastHit.collider.name == "BeachCleanupPlayer2")
                {
                    ObjectSelectedPlayer2 = true;
                    player2.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer2 = false;
                }
                if (raycastHit.collider.name == "FishingBoatsPlayer2")
                {
                    ObjectSelectedPlayer2 = true;
                    player2.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer2 = false;
                }
                if (raycastHit.collider.name == "InterceptorPlayer2")
                {
                    ObjectSelectedPlayer2 = true;
                    player2.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer2 = false;
                }
                if (raycastHit.collider.name == "ProjectCleanupPlayer2")
                {
                    ObjectSelectedPlayer2 = true;
                    player2.transform.GetChild(0).gameObject.SetActive(false);
                    onPlayer2 = false;
                }
                if (ObjectSelectedPlayer2)
                {
                    GameObject padPlayer2;
                    selectedPadPlayer2 = raycastHit.collider.name;

                    if (selectedPadPlayer2.StartsWith("SelectField2"))
                    {
                        padPlayer2 = GameObject.Find(selectedPadPlayer2);
                        Instantiate(Vangnet, padPlayer2.transform.position, Quaternion.identity);
                        ObjectSelectedPlayer2 = false;
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