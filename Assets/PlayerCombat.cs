using System.Reflection;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 10;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

   
    public void AttackOne(InputAction.CallbackContext context)
    {
        // This method is called when the attack button is pressed
        if(context.performed && Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + 1f / attackRate;
            // This is to make the player attack when the attack button is pressed but there is a delay so that the player can't spam the attack button
        }
        if(context.canceled)
        {
            animator.SetBool("Attacking1", false);
            // When the attack button is released, the attacking animation is stopped
        }
    }

    void Attack()
    {
        animator.SetBool("Attacking1", true);

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            UnityEngine.Debug.Log("Hit " + enemy.name);
            enemy.GetComponent<TrainingDummyHealth>().TakeDamage(attackDamage);
        }
        // This method is called when the attack button is pressed and takes damage from the enemy if it is in range
    }

    void OnDrawGizmosSelected()
    {

        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
        // This is to draw a circle around the attack point to visualise the attack radius
    }
}
