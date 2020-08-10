using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    [SerializeField]
    private int startCountDown = 60;

    [SerializeField]
    Text TxtTimeLeft;

    [SerializeField]
    Text TxtLevel;


    // Start is called before the first frame update
    void Start()
    {
        int levelToLoad = PlayerPrefs.GetInt("DenierNiveau");
        if (levelToLoad < 1) { levelToLoad = 1; }
        TxtLevel.text = "Level: " + levelToLoad;

        TxtTimeLeft.text = "TimeLeft: " + startCountDown;
        
        StartCoroutine(Pause());
    }

    IEnumerator Pause()
    {
        while (startCountDown > 0)
        {
            yield return new WaitForSeconds(1f);
            startCountDown--;
            TxtTimeLeft.text = "TimeLeft: " + startCountDown;
        }

        Debug.Log("You are died!!!");

        GameObject.Find("Menu").GetComponent<PlayerController>().GameOver();
    }

}
