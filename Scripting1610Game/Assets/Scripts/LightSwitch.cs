using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{
    public UnityEvent Event;

    public bool DinnerTime;

    private void Update()
    {
        if (DinnerTime)
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
            Event.Invoke();
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.black;
            Event.Invoke();
        }
    }

}  
