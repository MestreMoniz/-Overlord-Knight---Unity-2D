using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesMeleeAtack : MonoBehaviour
{
    public AudioSource AudioSource;
    public AudioClip atackClip;
    public int attackDamage = 40;
    public float attackRange = 3f;
    public GameObject circlePrefab; // Prefab do círculo
    public bool IsBoss = false;

    [SerializeField] public Transform attackPoint;
    


    public LayerMask attackMask;

    public void Attack()
    {
        if (IsBoss)
        {
            AudioSource.PlayOneShot(atackClip, 1f);
        }
        DrawAffectedArea();
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

     public void DrawAffectedArea()
    {
        GameObject circle = Instantiate(circlePrefab, attackPoint.position, Quaternion.identity);
       // circle.transform.localScale = new Vector3(attackRange * 2, attackRange * 2, 1);

        // Destruir o círculo após 1 segundo
        Destroy(circle, 1f);
    }

}
