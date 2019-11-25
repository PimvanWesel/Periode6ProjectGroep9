using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerRike : MonoBehaviour
{
    private void Update()
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
                    Debug.Log("button 3 clicked");
                }
                if (raycastHit.collider.name == "Player 4")
                {
                    Debug.Log("button 4 clicked");
                }
            }
        }
    }
}