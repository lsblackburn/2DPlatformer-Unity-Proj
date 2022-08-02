using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingDummyHealth : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 5;
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
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            Death();
        }
        // Function to take damage
    }

    void Death()
    {
        UnityEngine.Debug.Log("Enemy Died");
        // Function to handle enemy death
        animator.SetBool("IsDead", true);
        this.enabled = false;
        GetComponent<Collider2D>().enabled = false;
    }
}
