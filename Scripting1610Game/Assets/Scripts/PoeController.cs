using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoeController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        Vector2 postition = transform.position;
        postition.x = postition.x + 0.1f;
        transform.position = postition;
    }
}
