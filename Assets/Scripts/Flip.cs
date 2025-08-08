using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour
{
    public Transform player;

    public bool isFlipped = false;

    private void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Player");
        player = go.transform.GetChild(0);
    }

    public void LookAtPlayer()
    {
        if (player == null)
        { this.enabled = false; }
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }
}
