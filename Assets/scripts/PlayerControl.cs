using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float Speed;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
         // moveVelocity = moveInput * Speed;
        // rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
       //  rb.velocity = moveInput * Speed * Time.deltaTime;
        moveInput = moveInput * Speed * Time.deltaTime;
        transform.position += new Vector3(moveInput.x, moveInput.y);
    }
}
