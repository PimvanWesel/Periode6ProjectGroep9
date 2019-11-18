using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float seconds;
    public float round;

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
