using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

    public int Value = 3, MinValue = 0;
    public float WaitTime = 1;

    private IEnumerator Start()
    {
        var waitObj = new WaitForSeconds(WaitTime);
        
        while (Value > MinValue)
        {
            yield return waitObj;
            print(Value);
            Value--;
        }
    }
}
