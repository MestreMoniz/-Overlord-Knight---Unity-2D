using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int health = 100;

    public Animator animator;

    public GameObject deathEffect;

    [SerializeField] Transform target;

    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    private void Update()
    {
        agent.SetDestination(target.position);
        animator.SetFloat("Speed", agent.speed); 

    }
    public void TakeDmage(int damage)
    {
        health -= damage;
        animator.SetTrigger("Hurt");

        if (health <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        if (deathEffect != null)
        {
            Instantiate(deathEffect,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }

        else
        {
            animator.SetBool("IsDead", true);
            GetComponent<Collider2D>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            Destroy(gameObject,5);
            

            this.enabled = false;
        }
    }


}
