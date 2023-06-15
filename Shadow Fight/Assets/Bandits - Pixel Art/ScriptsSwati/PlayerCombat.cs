using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;

    //public Animator m_animator;

    //public Transform attackPoint;
    //public LayerMask enemyLayers;

    //public float attackRange = 0.5f;
    //public int attackDamage = 40;

    //public float _hitPoint = 100f;

    void Update()
    {
        if (!PauseMenu.isPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
            }
        }

       
    }

    void Attack()
    {
        animator.SetTrigger("Attack"); //play attack animation     
    }

}
