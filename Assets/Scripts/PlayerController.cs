//Zach Rhodes | 4/25/2024 | Player Script
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Animator animator;
    public Transform playerT;

    private Vector2 moveInput;

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    void Move()
    {
        //Getting movements
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        //Setting animator
        animator.SetFloat("Horizontal", moveInput.x);
        animator.SetFloat("Vertical", moveInput.y);
        animator.SetFloat("Speed", moveInput.sqrMagnitude);
        //Normalizing Movement
        moveInput.Normalize();
        //Applying Movement
        rb.velocity = moveInput * moveSpeed;
    }
}
