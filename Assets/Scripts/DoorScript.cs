using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //   Debug.Log(other.name + " est à l'interieur du trigger");
            GetComponent<Animator>().enabled = true;
        }
    }


}
