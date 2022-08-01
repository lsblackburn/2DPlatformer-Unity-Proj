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
    }

    // Update is called once per frame
    public void TakeDamageTest(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        currentHealth -= 10;
        healthBar.SetHealth(currentHealth);
    }
}
