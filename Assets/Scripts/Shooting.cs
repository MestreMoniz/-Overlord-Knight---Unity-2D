using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour

{
    // Start is called before the first frame update

    public AudioSource AudioSource;
    public AudioClip ShootClip;

    public Animator animator;
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float attackRate = 2f;
    float nextAttackTime = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                nextAttackTime = Time.time + 1f / attackRate;

            }
        }   
        
    }
    void Shoot()
    {
        animator.SetTrigger("Cast");
        AudioSource.PlayOneShot(ShootClip, 0.2f);


        GameObject bullet = Instantiate(bulletPrefab,firePoint.position,firePoint.rotation);
        //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(-firePoint .right * bulletForce,ForceMode2D.Impulse);
    }
}
