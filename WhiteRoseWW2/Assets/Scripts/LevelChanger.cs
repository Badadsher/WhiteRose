using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelChanger : MonoBehaviour
{
    [SerializeField] private int levelToLoad;
    private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void FadeToLevel()
    {
        anim.SetTrigger("fade");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);

    }
}
