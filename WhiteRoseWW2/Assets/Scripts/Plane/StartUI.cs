using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class StartUI : MonoBehaviour
{
    [SerializeField] private GameObject instruction;
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject startUI;

    private void Awake()
    {
        if (EditorPrefs.GetInt("CurrentSceneIndex") == 4)
        {
            Animator anim = startUI.GetComponent<Animator>();
            anim.Play("startuiforplane");
        }
        else
        {
            anim.Play("startUIOPEN");
        }
    }
    public void OnInstruction()
    {
        instruction.SetActive(true);
    }
    public void StartPlane()
    {
            Time.timeScale = 0f;
           
    }

    public void Letsgo()
    {
        anim.SetTrigger("IsTriggered");
        Time.timeScale = 1f;
    
    }

    public void CloseInstruction()
    {
        instruction.SetActive(false);
    }
}
