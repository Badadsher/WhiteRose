using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float dirX = 0;
    private SpriteRenderer sprite;
    private BoxCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;
    private enum MovementState { idle, PredRun, Run, Jump, Fall, poslerun }
  
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;
    [SerializeField] private PlayerLRBT movebt;
    
    private bool isJump;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        coll = GetComponent<BoxCollider2D>();

    }


    private void Update()
    {
        if (isJump && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        if(movebt.isMoveRight == true)
        {
            dirX = 1f;
        }
        else if (movebt.isMoveLeft == true)
        {
            dirX = -1f;
        }
        else
        {
            dirX = 0f;
        }
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);
        UpdateAnimationState();

        isJump = false;

    }

    public void Jump()
    {
        isJump = true;
    }
    private void UpdateAnimationState()
        {

     
        MovementState state;
        if (movebt.isMoveRight)
        {
            state = MovementState.Run;
            sprite.flipX = false;
        }
        else if (movebt.isMoveLeft)
        {
            state = MovementState.Run;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if (rb.velocity.y > .1f)
        {
            state = MovementState.Jump;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.Fall;
        }    
            anim.SetInteger("state", (int)state);
    
        }

 

    private bool IsGrounded()
    {
       return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
