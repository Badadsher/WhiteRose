using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterDoorScript : MonoBehaviour
{
    [SerializeField] private GameObject loader;
    public void EnterDoor()
    {
        loader.SetActive(true);
    }
}
