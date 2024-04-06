using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveInput;
    public Vector2 lastMove;
        


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Move();

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Interact();
        }

        void Interact()
        {
            var facingDir = new Vector3(lastMove.x, lastMove.y);
            var interactPos = transform.position + facingDir;

            Debug.DrawLine(transform.position, interactPos, Color.red, 3f, false);

            var collider = Physics2D.OverlapCircle(interactPos, 0.2f);
            if (collider != null)
            {
                Debug.Log("There is an NPC here!");
            }
        }

    }
    void Move()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        moveInput.Normalize();
        rb.velocity = moveInput * moveSpeed;
        
    }
    
}
