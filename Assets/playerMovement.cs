using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
#region Variables
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public Animator am;

    private float horizontal;
    private float speed = 8f;
    private float jumpForce = 8f;
    private bool isFacingRight = true;
#endregion
    // Update is called once per frame
    void Update()
    {
        am.SetBool("Jumping", !IsGrounded());
        // Sets the Jumping animation parameter to true if the player is not grounded

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        // This is moves the player left and right

        am.SetFloat("Speed", Mathf.Abs(horizontal));
        //This changes the animation to running animation

#region Flip Sprite
        if(!isFacingRight && horizontal > 0f)
        {
            Flip();
        }
        else if(isFacingRight && horizontal < 0f)
        {
            Flip();
        }
        // This flips the sprite in the update method
#endregion
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            // This is to make the player jump when the jump button is pressed
            // and the player is on the ground
            am.SetBool("Jumping", true);
        }

        if (context.canceled)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
            // This is to make sure that the player doesn't keep jumping when the button is released
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
        // This is to check if the player is on the ground
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
        // This method is used to flip the player sprite
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        // This method is called every frame while the action is bound to a control
    }
    
}