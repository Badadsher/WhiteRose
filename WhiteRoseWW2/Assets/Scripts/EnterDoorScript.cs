using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoorScript : MonoBehaviour
{
    [SerializeField] private int levelToLoad;
    public void EnterDoor()
    {
        SceneManager.LoadScene(levelToLoad);
        Debug.Log(message: "Активно");
    }
}
