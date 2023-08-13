using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text moneycount;
    public int money = 0;
    [SerializeField] private GameObject startUI;
    void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        EditorPrefs.SetInt("CurrentSceneIndex", currentSceneIndex);
        moneycount.text = PlayerPrefs.GetInt("money").ToString();
        startUI.SetActive(true);
        Time.timeScale = 1f;
        AudioSource[] audios = FindObjectsOfType<AudioSource>();

        foreach (AudioSource a in audios)
        {
            a.Play();
        }

    }
    void Update()
    {
        moneycount.text = PlayerPrefs.GetInt("money").ToString();
        PlayerPrefs.Save();
    }
}
