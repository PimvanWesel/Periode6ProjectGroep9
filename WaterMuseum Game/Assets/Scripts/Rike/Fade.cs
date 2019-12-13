using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    private float colora = 1, colora2 = 1;
    private bool fulla;
    private MeshRenderer[] r_Player1, r_Player2, r_Player3, r_Player4;

    private void Start()
    {
        r_Player1 = GameObject.Find("FieldsPlayer1").GetComponentsInChildren<MeshRenderer>();
        r_Player2 = GameObject.Find("FieldsPlayer2").GetComponentsInChildren<MeshRenderer>();
        r_Player3 = GameObject.Find("FieldsPlayer3").GetComponentsInChildren<MeshRenderer>();
        r_Player4 = GameObject.Find("FieldsPlayer4").GetComponentsInChildren<MeshRenderer>();
    }

    private void Update()
    {
        if (colora <= 0)
            fulla = false;
        if (colora >= 1)
            fulla = true;

        if (fulla)
        {
            colora -= 1f * Time.deltaTime;
        }
        if (!fulla)
        {
            colora += 1f * Time.deltaTime;
        }

        if (GameManagerRike.Instance.ObjectSelectedPlayer1)
        {
            foreach (MeshRenderer rend in r_Player1)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, colora);
            }
        }
        else
        {
            foreach (MeshRenderer rend in r_Player1)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0f);
            }
        }

        if (GameManagerRike.Instance.ObjectSelectedPlayer2)
        {
            foreach (MeshRenderer rend in r_Player2)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, colora);
            }
        }
        else
        {
            foreach (MeshRenderer rend in r_Player2)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0f);
            }
        }

        if (GameManagerRike.Instance.ObjectSelectedPlayer3)
        {
            foreach (MeshRenderer rend in r_Player3)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, colora);
            }
        }
        else
        {
            foreach (MeshRenderer rend in r_Player3)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0f);
            }
        }

        if (GameManagerRike.Instance.ObjectSelectedPlayer4)
        {
            foreach (MeshRenderer rend in r_Player4)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, colora);
            }
        }
        else
        {
            foreach (MeshRenderer rend in r_Player4)
            {
                rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0f);
            }
        }
    }
}