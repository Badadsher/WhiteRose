using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhen : MonoBehaviour
{
    [SerializeField] private AudioClip BoomSound;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,1f);
        GetComponent<AudioSource>().PlayOneShot(BoomSound);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
