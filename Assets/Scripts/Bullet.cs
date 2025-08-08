using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;

    public GameObject hitEffect;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = -transform.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EnemiesLife enemy =  collision.GetComponent<EnemiesLife>();
        if (enemy != null)
        {
            enemy.TakeDmage(damage);
        }
        GameObject hit = Instantiate(hitEffect, transform.position, transform.rotation);
        Destroy(hit,10);
        Destroy(gameObject);


    }
    //private void OntriggerEnter2D (Collision2D collision)
    //{
    //    GameObject effect = Instantiate(hitEffect,transform.position, Quaternion.identity);
    //    Destroy(effect,5f);
    //    Destroy(gameObject);
    //}
}
