using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterBurnerScript : MonoBehaviour
{

    [SerializeField]
    int LevelToLoad;

    [SerializeField]
    bool autoIndex = true;

    private void Start()
    {
        if (autoIndex)
        {
            LevelToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
           // Debug.Log("win");
            //recupera el indice de la scena y va a la siguiente
            SceneManager.LoadScene(LevelToLoad);
        }
    }

}
