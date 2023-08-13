using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{
    public GameObject LoadingScreen;

    public Slider scale;

    [SerializeField] private int levelToLoad;

    public void Loading()
    {
        LoadingScreen.SetActive(true);

        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation loadAsync = SceneManager.LoadSceneAsync(levelToLoad);
        loadAsync.allowSceneActivation = false;

        while (!loadAsync.isDone)
        {
            scale.value = loadAsync.progress;
            if (loadAsync.progress >= .9f && !loadAsync.allowSceneActivation)
            {
                yield return new WaitForSeconds(2.2f);
                loadAsync.allowSceneActivation=true;    
            }
            yield return null;
        }

    }
}
