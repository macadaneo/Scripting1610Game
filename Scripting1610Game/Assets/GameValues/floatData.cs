using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class floatData : ScriptableObject
{
    [SerializeField] private float value = 10;

    public float Value
    {
        get { return value;}
        set { this.value = value; }
    }

    public void UpdateValue(float floatInput)
    {
        Value += floatInput;
    }

    public void UpdateValue(floatData dataObj)
    {
        Value += dataObj.Value;
    }
}
