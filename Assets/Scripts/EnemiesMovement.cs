using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemiesMovement : MonoBehaviour
{
    NavMeshAgent agent;
    Flip flip;
    EnemiesMeleeAtack enemiesMeleeAtack;

    Vector3 offset;

    public Animator animator;

    [SerializeField] public Transform player;
    [SerializeField] public Transform attackPoint;

    public bool haveAtackAnimation = true;

    private float distance;

    public float attackRange = 3f;
    public float atackRate = 0.5f;
    float nextAttackTime = 0f;

    private Transform Body;





    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        flip = GetComponent<Flip>();
        enemiesMeleeAtack = GetComponent<EnemiesMeleeAtack>();

        offset = attackPoint.transform.position - transform.position;

        GameObject go = GameObject.FindGameObjectWithTag("Player");
        player = go.transform.GetChild(0);
        Debug.Log("Body = " + player.name);


    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
            { this.enabled =false; }
        flip.LookAtPlayer();

       // Debug.Log("Body.transform.position - offset = " + (Body.transform.position -offset));
        agent.SetDestination(player.transform.position - offset);
        animator.SetFloat("Speed", agent.speed);
        distance = Vector2.Distance(player.transform.position, attackPoint.transform.position);
        if (distance <= attackRange)
        {
            if (haveAtackAnimation)
            {
                animator.SetTrigger("Attack");
            }
            else
            {

                if (Time.time >= nextAttackTime)
                {
                    enemiesMeleeAtack.Attack();
                    nextAttackTime = Time.time + 1f / atackRate;

                }

            }


        }


    }
}
