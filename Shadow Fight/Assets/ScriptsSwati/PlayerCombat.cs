using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;
    
    public float attackRange = 0.5f;
    public int attackDamage = 40;

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
        Attack();
       } 
    }

    void Attack()
    {
        animator.SetTrigger("Attack"); //play attack animation

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers); //to detect enemies in range of attack

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected() //allow us to draw stuff in the editor whenever the object is selected
    {
        if(attackPoint == null)
        return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
