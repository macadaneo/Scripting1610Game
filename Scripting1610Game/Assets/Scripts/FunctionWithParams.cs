using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class FunctionWithParams : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AddData(12.5f, 8.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddData(float a, float b)
    {
        print(a+b);
    }

    private void OnTriggerEnter(Collider obj)
    {
        obj.gameObject.SetActive(false);
    }
}
