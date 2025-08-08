using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerHealth : MonoBehaviour

{
    public AudioSource AudioSource;
    public AudioClip HurtClip;
    public AudioClip DiedClip;
    public ControlScreens ControlScreens;
    public int maxHealth = 200;
    public int currentHealth;
    public HealthBar healthBar;

    public Animator animator;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    // Start is called before the first frame update
    public void TakeDmage(int damage)
    {
        Debug.Log("entro aqui");
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        animator.SetTrigger("Hurt");
        AudioSource.PlayOneShot(HurtClip, 0.5f);

        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public void addHHealth(int health)
    {
        if (currentHealth + health > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else
        {
            currentHealth = currentHealth + health;
        }
        healthBar.SetHealth(currentHealth);
    }

    void Die()
    {
        AudioSource.PlayOneShot(DiedClip, 0.5f);


        animator.SetBool("IsDead", true);
            GetComponent<Collider2D>().enabled = false;
            Destroy(gameObject, 5);

            GetComponent<PlayerMovement>().enabled = false;
            ControlScreens.showEndScreen();
            this.enabled = false;


    }
}
