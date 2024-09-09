using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 8f;
    private float horizontal;
    private Rigidbody2D rb;
    private Animator animator;
    private bool isFacingRight = true;
    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        this.rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space))
        {
             this.rb .AddForce(Vector2.up *8F, ForceMode2D.Impulse);
        }
        animator.SetFloat("speed", Mathf.Abs(horizontal));
        Flip();
    }
    private void Flip() { 
    if(isFacingRight && horizontal < 0f || !isFacingRight && horizontal>0){
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale; 
        }
    
}}
