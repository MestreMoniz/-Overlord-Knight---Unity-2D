using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class BossMovement : MonoBehaviour
{
    NavMeshAgent agent;
    Flip flip;

    [SerializeField] public Transform target;
    public Transform attackPoint;

    public Animator animator;
    Vector3 offset;

    public float attackRange = 3f;

    private float distance;




    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        flip = GetComponent<Flip>();
        offset = attackPoint.transform.position - transform.position;


    }

    // Update is called once per frame
    void Update()
    {
        flip.LookAtPlayer();

        agent.SetDestination(target.transform.position - offset);
        animator.SetFloat("Speed", agent.speed);



        distance = Vector2.Distance(target.transform.position, attackPoint.transform.position);


        if (distance <= attackRange)
        {
            //Debug.Log("distance = " + distance);

            animator.SetTrigger("Attack");
        }

    }
}
