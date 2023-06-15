using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    public Transform attackPoint;
    public LayerMask enemyLayers;
    
    public float attackRange = 0.5f;
    public int attackDamage = 40;

    public float _hitPoint = 100f;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("attack1"))
        {
            TakeDamage();
            Debug.Log("attack1");
        }
    }

    private void TakeDamage()
    {
        _hitPoint -= 10;
        animator.SetTrigger("Hurt");

        // Add code here to handle health bar updates or other actions when taking damage

        if (_hitPoint <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        animator.SetBool("isDead", true);
    }


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
    }

}
