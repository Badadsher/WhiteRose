using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadingScript : MonoBehaviour
{
    private static bool gameIsPaused = false;
    [SerializeField] private GameObject newsPaperUI;
    [SerializeField] private Animator anim;
        public void StopRead()
        {

            if (gameIsPaused)
            {
                NotReading();
            }
        }

    public void NotReading()
    {
        Time.timeScale = 1f;
        gameIsPaused = false;
        anim.SetTrigger("IsTriggered");
    }
    public void Reading()
    {
        newsPaperUI.SetActive(true);
        gameIsPaused = true;
    }

    public void NotReadingON()
    {
        newsPaperUI.SetActive(false);
        anim.SetTrigger("IsTriggered");
    }
}
