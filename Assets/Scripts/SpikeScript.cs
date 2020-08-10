using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.tag );

        if(collision.collider.tag == "Player")
        {
            GameObject.Find("Player").GetComponent<PlayerController>().GameOver();
        }
    }

}
