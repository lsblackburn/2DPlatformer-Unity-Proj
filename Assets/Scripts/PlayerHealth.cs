using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        // Sets the max health of the player health bar at the start of the game
    }

    // Update is called once per frame
    public void TakeDamageTest(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            TakeDamage();
            // Function to test taking damage on player
        }
    }

    void TakeDamage()
    {
        currentHealth -= 10;
        healthBar.SetHealth(currentHealth);
        // Function to take damage
    }
}
