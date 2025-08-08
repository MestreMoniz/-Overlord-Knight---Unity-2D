using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip AttackClip;
    public Animator animator;
    public Transform attackPoint;
    
    public LayerMask enemyLayer;

    public int attackDamage = 40;
    public float attackRange = 0.5f;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
        
    }

    void Attack()
    {
        //play an attack animation
        animator.SetTrigger("Atack");
        AudioSource.PlayOneShot(AttackClip, 0.2f);
        // Detect enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        //Damage them

        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("WE HIT" + enemy.name);
            enemy.GetComponent<EnemiesLife>().TakeDmage(attackDamage);
        }
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}
