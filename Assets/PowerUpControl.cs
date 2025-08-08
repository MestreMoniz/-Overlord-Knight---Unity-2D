using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpControl : MonoBehaviour
{
    public GameObject[] PowerUps;
    public float[] weights;
    public float SpawnChance = 0.2f;
    private int index;
    // Start is called before the first frame update


    public void SpawnPowerUp(Vector3 position)
    {
        if (Random.value < SpawnChance)
        {
            index = GetRandomWeightedIndex();
            if (index == -1)
                return;
            Instantiate(PowerUps[index], position, Quaternion.identity);

        }
    }
    public int GetRandomWeightedIndex()
    {
        if (weights == null || weights.Length == 0) return -1;

        float w;
        float t = 0;
        int i;
        for (i = 0; i < weights.Length; i++)
        {
            w = weights[i];

            if (float.IsPositiveInfinity(w))
            {
                return i;
            }
            else if (w >= 0f && !float.IsNaN(w))
            {
                t += weights[i];
            }
        }

        float r = Random.value;
        float s = 0f;

        for (i = 0; i < weights.Length; i++)
        {
            w = weights[i];
            if (float.IsNaN(w) || w <= 0f) continue;

            s += w / t;
            if (s >= r) return i;
        }

        return -1;
    }

    
}
