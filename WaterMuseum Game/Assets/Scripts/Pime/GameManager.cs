using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float seconds;
    public float round;

    public int moneyP1;
    public int moneyP2;
    public int moneyP3;
    public int moneyP4;

    public Text amountP1;
    public Text amountP2;
    public Text amountP3;
    public Text amountP4;

    public Text sec;
    public Text rounds;

    void Start()
    {
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
    }

    void RestartSeconds()
    {
        seconds = 30;
        round++;      
    }
}
