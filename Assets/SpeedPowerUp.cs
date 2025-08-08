using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public float SpeedIncrement = 0.2f;
    public AudioSource AudioSource;
    // Start is called before the first frame update
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        AddPowerUp PowerUp = collision.GetComponent<AddPowerUp>();
        if (PowerUp != null)
        {
            AudioSource.Play();
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            PowerUp.AddSpeed(SpeedIncrement);
            Destroy(gameObject,1);

        }


    }
}
