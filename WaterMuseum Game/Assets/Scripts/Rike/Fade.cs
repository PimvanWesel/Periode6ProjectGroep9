using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public float colora = 1;
    private bool fulla;

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

        GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r, GetComponent<Renderer>().material.color.g, GetComponent<Renderer>().material.color.b, colora);
    }
}