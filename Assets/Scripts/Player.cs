using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float horizontal;
    private Rigidbody2D rb;
    private bool isFacingRight = true;
    // Update is called once per frame
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);
        this.rb.velocity = new Vector2(horizontal * 8f, rb.velocity.y);
        Flip();
    }
    private void Flip() { 
    if(isFacingRight && horizontal < 0f || isFacingRight && horizontal>0){
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale; 
        }
    
}}
