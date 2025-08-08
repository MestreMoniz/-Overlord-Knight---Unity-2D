using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class EnemiesLife : MonoBehaviour
{

    public AudioSource AudioSource;
    public AudioClip DiedClip;
    public int maxHealth = 500;
    public int currentHealth;

    public Animator animator;
    public GameObject deathEffect;
    public HealthBar healthBar;
    public bool IsBoss = false;

    private PowerUpControl powerUpControl;

    void Start()
    {
        currentHealth = maxHealth;

        if (healthBar != null)
        {
            healthBar.SetMaxHealth(maxHealth);
        }
        if (IsBoss)
        {
            AudioSource.Play();

        }
        GameObject GameMaster = GameObject.FindGameObjectWithTag("GameMaster");
        powerUpControl= GameMaster.GetComponent<PowerUpControl>();
       

    }

    public void TakeDmage(int damage)
    {
        

        currentHealth -= damage;
        if (healthBar != null)
        {
            healthBar.SetHealth(currentHealth);

        }
        animator.SetTrigger("Hurt");

        if (currentHealth <= 0)
        {

            Die();
        }
    }


    void Die()
    {
        if (IsBoss)
        {
            AudioSource.clip = DiedClip;
            AudioSource.Play();
        }
          
        if (deathEffect != null)
        {
            
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            powerUpControl.SpawnPowerUp(transform.position);

            Destroy(effect, 5);
            Destroy(gameObject);

        }

        else
        {
            animator.SetBool("IsDead", true);
            GetComponent<Collider2D>().enabled = false;
            GetComponent<EnemiesMovement>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            powerUpControl.SpawnPowerUp(transform.position);

            Destroy(gameObject, 5);


            this.enabled = false;
        }
    }
}
