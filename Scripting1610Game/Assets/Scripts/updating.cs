using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updating : MonoBehaviour
{
    public bool _canRun = true;
    
    private WaitForFixedUpdate _fixed;

    public bool CanRun
    {
        get { return _canRun; }
        set { _canRun = value; }
    }

    public void BeginCoroutine()
    {
        CanRun = true;
        StartCoroutine(RunCoroutine());
    }
    
    
    
    private IEnumerator RunCoroutine()
    {
        _fixed = new WaitForFixedUpdate();
        yield return _fixed;
        print("Start");
        while (CanRun)
        {
           yield return _fixed;
           print("Running");
        }
    }
}
