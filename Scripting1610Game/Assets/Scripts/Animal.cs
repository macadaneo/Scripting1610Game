using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Animal : MonoBehaviour
{
    public string Name;
    public int FurCount = 10000;
    public float EatingSpeed = 0.4f;
    public bool CanEat = true;
    public UnityEvent Event;
    public Color SkinColor;
    public Color EyeColor;
    public floatData Health;
    public floatData Speed;
    public bool CanMove;
    
    public void Move()
    {
        print("Saadan");
    }

    private void Start()
    {
        Event.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
       //Do Work 
    }
}
