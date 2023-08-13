using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCount : MonoBehaviour
{
    Text text;
    public static int enemys;
    public GameObject endUI;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        enemys = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = enemys.ToString(); 
        if(enemys == 25)
        {
            endUI.SetActive(true);
            PlayerPrefs.Save();
        }
    }
}
