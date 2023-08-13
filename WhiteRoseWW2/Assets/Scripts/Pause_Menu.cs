
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{
    [SerializeField] private static bool GameIsPaused = false;
    [SerializeField] private GameObject pauseMenuUI;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject loadmenuAUI;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();             
            }
            else
            {
                Pause();
            }
          
        }
    }
    public void ButtonPause()
    {

        if (GameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void Resume()
    {
        anim.SetTrigger("IsTriggered");
        Time.timeScale = 1f;
        GameIsPaused = false;

        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in audios)
        {
            a.Play();
        }
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
    }

    public void PauseON()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in audios)
        {
            a.Pause();
        }
    }
    public void LoadMenu()
    {
        loadmenuAUI.SetActive(true);
        Time.timeScale = 1f;
    }
    public void LoadMenuON()
    {
        SceneManager.LoadScene(0);
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void OffBt()
    {
         pauseMenuUI.SetActive(false);
        anim.SetTrigger("IsTriggered");
    }
}
