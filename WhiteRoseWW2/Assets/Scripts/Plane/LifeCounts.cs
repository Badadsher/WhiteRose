using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeCounts : MonoBehaviour
{
    [SerializeField] private GameObject[] livesIcons;
    public static int currentLifeIndex = 4;
    [SerializeField] private GameObject loseUI;
    public static bool GameIsPaused = false;

    // Start is called before the first frame update
    private void Start()
    {
        currentLifeIndex = 4;
    }   

    private void Update()
    {
        if (livesIcons[1].activeSelf==false)
        {
            loseUI.SetActive(true);

            AudioSource[] audios = FindObjectsOfType<AudioSource>();
            foreach (AudioSource a in audios)
            {
                a.Pause();
            }
        }
    }
    // метод, который будет вызываться, чтобы выключить следующий объект в массиве
    public void DisableNextLife()
    {
        if (currentLifeIndex < livesIcons.Length) //если индекс становится меньше 3ех объектов массива-отключаем иконку
        {
            livesIcons[currentLifeIndex].SetActive(false);
        }

      
    }

    public void Restart()
    {
       
        SceneManager.LoadScene(4);
       
    }
}
