using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public List<Object> CollectionList;
    
    
    public void Collect(Object obj)
    {
            CollectionList.Add(obj);
    }
    
}
