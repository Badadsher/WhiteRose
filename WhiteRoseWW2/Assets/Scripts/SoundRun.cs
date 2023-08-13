using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRun : MonoBehaviour
{
    private Rigidbody2D rb;
    public AudioSource moveSound;
    private float dirX = 0;
    [SerializeField] private PlayerLRBT movebt;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    

    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        if (movebt.isMoveRight == true && rb.velocity.y > -0.589f) 
        {
            if (moveSound.isPlaying) return;
            moveSound.Play();
        }
        else if (movebt.isMoveLeft == true && rb.velocity.y > -0.589f)
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

