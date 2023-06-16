using UnityEngine;

public class PlayerCombat : MonoBehaviour
{

    public Animator animator;
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
