using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D element)
    {
        if (element.tag== "Player")
        {
            print("Bunny is dead");
            PlayerController.GetInstance().KillPlayer();
        }
    }
}
