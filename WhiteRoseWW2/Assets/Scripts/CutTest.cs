using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutTest : MonoBehaviour
{
    [SerializeField] private GameObject TimeLine;

    void Start()
    {
            CutsceneManager.Instance.StartCutscene("Cutscene_1");
        TimeLine.SetActive(true);
    }

    private void Update()
    {
      
    }
}
