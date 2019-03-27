using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<floatData> CollectionList;
    
    
    public void Collect(floatData obj)
    {
            CollectionList.Add(obj);
    }

    public void CollectionInfo()
    {
        foreach (var obj in CollectionList)
        {
            Debug.Log(obj);
        }
    }

    public void AmmoInfo()
    {
        foreach (var obj in CollectionList)
        {
            if (obj.name == "Ammo")
            {
                Debug.Log("We have " + obj.Value + " ammo.");
            }
        }
    }

    public void FuelInfo()
    {
        for (int i = 0; i < CollectionList.Count; i++)
        {
            if (CollectionList[i].name == "Fuel")
            {
                Debug.Log(CollectionList[i]);
            }
        }
    }
}
