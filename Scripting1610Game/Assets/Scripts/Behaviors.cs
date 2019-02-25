using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Behaviors : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent Event;

    private void Start()
    {
        Event.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        Event.Invoke();
    }

    void OnCollisionEnter()
    {
        Event.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        Event.Invoke();
    }
}
