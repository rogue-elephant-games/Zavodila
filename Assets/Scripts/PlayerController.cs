using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public float moveSpeed;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.velocity =
            new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed,
                Input.GetAxisRaw("Vertical") * moveSpeed);
        animator.SetFloat("moveX", rigidbody.velocity.x);
        animator.SetFloat("moveY", rigidbody.velocity.y);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1)
        {
            animator.SetFloat("lastMoveY", 0f);
            animator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
        } 
        else if(Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            animator.SetFloat("lastMoveX", 0f);
            animator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
}
