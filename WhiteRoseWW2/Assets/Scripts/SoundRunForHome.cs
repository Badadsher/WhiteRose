using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRunForHome : MonoBehaviour
{
    private Rigidbody2D rb;
    public AudioSource moveSound;
    private float dirX = 0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    

    void Update()
    {
       
        dirX = Input.GetAxisRaw("Horizontal");
        if (dirX > 0f && rb.velocity.y > -0.589f) 
        {
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else if (dirX < 0f && rb.velocity.y > -0.589f)
        {
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else if (rb.velocity.y > -0.589f)
        {
            moveSound.Stop();
        }
        else if (rb.velocity.y > -0.589f)
        {
            moveSound.Stop();
        }


        else
        {
            moveSound.Stop();
        }
    }
}

