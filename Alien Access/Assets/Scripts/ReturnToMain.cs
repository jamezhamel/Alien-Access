using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReturnToMain : MonoBehaviour
{
    public void returnToMain()
    {
        SceneManager.LoadScene(0);

    }

    public void QuitGame()

    {
        Debug.Log("quit");
        Application.Quit();
    }
}
