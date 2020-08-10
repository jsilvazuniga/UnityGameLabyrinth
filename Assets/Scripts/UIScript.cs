using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIScript : MonoBehaviour
{
    public void QuitGame() 
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
    public void PlayGame()
    {
        PlayerPrefs.SetInt("DenierNiveau", 1);
        SceneManager.LoadScene("Level1");
    }

    public void ContinueGame()
    {
        int levelToLoad = PlayerPrefs.GetInt("DenierNiveau");

        if (levelToLoad > 1)
        {
            SceneManager.LoadScene(levelToLoad);
        }
        else
        {
            SceneManager.LoadScene("Level1");
        }
    }
}
