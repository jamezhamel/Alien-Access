using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathPlane : MonoBehaviour
{

    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    float m_Timer;
    bool m_Falling;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");

        if (collision.tag == "Player")
        {
           m_Falling = true;
        }

    }


    void Update()
    {
        if (m_Falling)
        {
            EndLevel();
        }
    }

    void EndLevel()
    {
        m_Timer += Time.deltaTime;

        exitBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            SceneManager.LoadScene(0);
        }
    }

}
