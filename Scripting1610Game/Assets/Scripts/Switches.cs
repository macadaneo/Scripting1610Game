using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    
    public enum States
    {
        Starting,
        Playing,
        Dying,
        Ending
    }

    public States CurrentState;


    private void Update()
    {
        switch (CurrentState)
        {
            case States.Starting:
                break;
            case States.Playing:
                break;
            case States.Ending:
                break;
            case States.Dying:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
