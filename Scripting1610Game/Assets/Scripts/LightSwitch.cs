using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{
    ParticleSystem CampFire;
    public bool DinnerTime = false;

    private void Start()
    {
        CampFire.Stop();
    }

    private void Update()
    {
        if (DinnerTime == true)
        {
           CampFire.Play();
        }
        else
        {
            CampFire.Stop();
        }
    }

}  
