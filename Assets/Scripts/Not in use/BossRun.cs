using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class BossRun : StateMachineBehaviour
{
    Flip flip;
    public float attackRange = 3f;
    Transform player;
    Transform enemy;
    Transform attackPoint;


    Rigidbody2D rb;
    private float distance;
    NavMeshAgent agent;
    Vector3 offset;



    //OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        player = GameObject.FindGameObjectWithTag("Player").transform.GetChild(0);
        //Debug.Log("player =" + player.transform.position.x + player.transform.position.y);
        Debug.Log("body name" + player.name);


        rb = animator.GetComponent<Rigidbody2D>();
        flip = animator.GetComponent<Flip>();
        enemy = animator.GetComponentInChildren<Transform>();
       // Debug.Log("enemy" + enemy.name);

        attackPoint = animator.GetComponentInChildren<Transform>().transform.GetChild(0);
        //Debug.Log("children name"  + attackPoint.name);
        // Debug.Log("attackPoint =" + attackPoint.transform.position.x + attackPoint.transform.position.y);

        offset = attackPoint.position - enemy.position;

        //Debug.Log("offset" + offset.x + ", " + offset.y);

        agent = animator.GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    //OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        flip.LookAtPlayer();

        

        agent.SetDestination(player.transform.position- offset);
        

        distance = Vector2.Distance(player.transform.position, attackPoint.transform.position);
       

        if (distance <= attackRange)
        {
            Debug.Log("distance = " + distance);

            animator.SetTrigger("Attack");
        }
    }

    //OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.ResetTrigger("Attack");
    }

}
