using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float correr = 2;
    public float saltar = 3;
    Rigidbody2D rb2D;
    public bool gransalto = true;
    public float multiplicador = 0.5f;
    public float bajo_multiplicador = 1f;
    public SpriteRenderer spriteRenderer;
    public Animator animator;
    
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(correr, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);
        }

        else if(Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2D.velocity = new Vector2(-correr, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);
        }
        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }
        if(Input.GetKey("space") && Ground.isGround)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, saltar);
        }
        if (Ground.isGround==false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (Ground.isGround==true)
        {
            animator.SetBool("Jump", false);
        }

        if (gransalto)
        {
            if (rb2D.velocity.y < 0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (multiplicador) * Time.deltaTime;
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("space"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (bajo_multiplicador) * Time.deltaTime;
            }
        }
    }
}
