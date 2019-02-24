using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : Mamal
{
    public Color AntlerColor;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = PrimaryHairColor;
        Event.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,1,0);
    }
}
