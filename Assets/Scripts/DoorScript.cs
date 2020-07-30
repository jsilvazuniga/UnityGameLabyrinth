using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool CanOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && CanOpen)
        {
            //   Debug.Log(other.name + " est à l'interieur du trigger");


            GetComponent<Animator>().enabled = true;
        }
    }


}
