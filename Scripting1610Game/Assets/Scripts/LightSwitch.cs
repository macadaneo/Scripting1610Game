using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{
    public UnityEvent OnEvent,OffEvent;

    public bool DinnerTime;

    private void Update()
    {
        if (DinnerTime)
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
            OnEvent.Invoke();
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.black;
            OffEvent.Invoke();
        }
    }

}  
