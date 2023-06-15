using UnityEngine;

public class DamagePlayerOne : MonoBehaviour
{
    public HeroKnight heroKnight;
    public HealthBar healthBar;

    private Animator animator;

    int currentHealth;
    private void Start()
    {
        healthBar.SetMaxHealth(100);
        animator = heroKnight.GetComponent<Animator>();
        currentHealth = 100;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player1")
        {
            TakeDmg();
        }
    }

    private void TakeDmg()
    {
        currentHealth -= 10;
        healthBar.SetHealth(currentHealth);
        if(currentHealth <= 0)
        {
            Die();
        }
        animator.SetTrigger("Hurt");
    }

    private void Die()
    {
        animator.SetTrigger("Death");
        Debug.Log("Player2 Won!");
        heroKnight.enabled = false;
    }


}
