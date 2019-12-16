using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float seconds;
    public float round;

    public static int vangnetPrijs = 25;
    public static int beachcleanerPrijs = 50;
    public static int fishingbootPrijs = 70;
    public static int interceptorPrijs = 100;
    public static int projectcleanerPrijs = 500;

    public static int moneyP1;
    public static int moneyP2;
    public static int moneyP3;
    public static int moneyP4;

    public static int oceanVervuiling = 0;
    public static GameObject ocean;

    public Text oceanText;

    [SerializeField]
    public Text[] moneyText;

    public Text sec;
    public Text rounds;

    void Start()
    {
        moneyP1 = 100;
        moneyP2 = 100;
        moneyP3 = 100;
        moneyP4 = 100;

        seconds = 30;
        round = 1;
        sec.text = seconds.ToString();
        rounds.text = round.ToString();
    }

    void Update()
    {
        if (seconds <= 30)
        {
            seconds = seconds - Time.deltaTime;
        }
        if (seconds <= 0)
        {
            RestartSeconds();
        }

        sec.text = "Seconde: " + Mathf.Round(seconds).ToString();
        rounds.text = "Ronde: " + Mathf.Round(round).ToString();

        moneyText[0].text = "Geld: " + moneyP1;
        moneyText[1].text = "Geld: " + moneyP2;
        moneyText[2].text = "Geld: " + moneyP3;
        moneyText[3].text = "Geld: " + moneyP4;

        oceanText.text = "Vervuiling: " + oceanVervuiling;
    }

    void RestartSeconds()
    {
        seconds = 30;
        round++;
    }

    
}
