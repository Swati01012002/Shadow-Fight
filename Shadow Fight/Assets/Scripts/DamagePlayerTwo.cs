using UnityEngine;
using UnityEngine.SceneManagement;

public class DamagePlayerTwo : MonoBehaviour
{
    public PlayerCombat playerCombat;
    public Movements movements;
    public HealthBar healthBar;

    private Animator animator;

    int currentHealth;
    private void Start()
    {
        healthBar.SetMaxHealth(100);
        animator = playerCombat.GetComponent<Animator>();
        currentHealth = 100;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player2")
        {
            TakeDmg();
        }
    }

    private void TakeDmg()
    {
        currentHealth -= 10;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
        animator.SetTrigger("Hurt");
    }

    private void Die()
    {
        animator.SetTrigger("Death");
        Debug.Log("Player1 Won!");
        playerCombat.enabled = false;
        movements.enabled = false;  
    }


}
