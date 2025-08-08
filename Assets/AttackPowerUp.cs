using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPowerUp : MonoBehaviour
{
    public int AttackIncrement = 40;
    public AudioSource audioSource;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddPowerUp PowerUp = collision.GetComponent<AddPowerUp>();
        if (PowerUp != null)
        {
            audioSource.Play();
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            PowerUp.AddAttack(AttackIncrement);
            Destroy(gameObject,1);

        }


    }
}
