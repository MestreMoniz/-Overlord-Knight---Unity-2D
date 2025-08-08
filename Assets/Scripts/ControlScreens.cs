using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlScreens : MonoBehaviour
{
    public GameObject EndScreen;
    public GameObject VictoryScreen;
    // Start is called before the first frame update
    
    public void showVicotoryScreen()
    {
        VictoryScreen.SetActive(true);
    }
    public void showEndScreen()
    {
        EndScreen.SetActive(true);
    }
}
