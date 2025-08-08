using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAtack : MonoBehaviour
{
    public int attackDamage = 40;
    public float attackRange = 3f;
    public Transform attackPoint;


    public LayerMask attackMask;

    public void Attack()
    {
        Collider2D hitInfo = Physics2D.OverlapCircle(attackPoint.position, attackRange, attackMask);
        if (hitInfo != null)
        {
            hitInfo.GetComponent<PlayerHealth>().TakeDmage(attackDamage); 
        }


    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }

}

