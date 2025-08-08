using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class WaveInformation : MonoBehaviour
{
    public TextMeshProUGUI nameWave;
    public TextMeshProUGUI timer;

    private float TimeOFwave;

       

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if(TimeOFwave - Time.deltaTime > 0)
        {
            TimeOFwave= TimeOFwave - Time.deltaTime;
            timer.text = TimeOFwave.ToString("F1") + "SECONDS";
        }

        else
        {
            gameObject.SetActive(false);

        }


    }

     public void Setup(string Namewave,float timeForNextWave)
    {
        if (timeForNextWave != 0){
            gameObject.SetActive(true);
            nameWave.text = Namewave;
            TimeOFwave = timeForNextWave;
        }
        
    }
}
