using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int Number = 11;
    public string Password;
    public bool CanWalk;
    
    
    void Update()
    {
        if (CanWalk)
        {
            print("true");
        }
        else
        {
            print(false);
        }

        if (Number >= 10)
        {
            print("greater");
        }
        else
        {
            print("lesser");
        }
        
        if (Password == "DOOM2016")
        {
            print("Correct");
        }
        else
        {
            print("Incorrect");
        }
    }
}
