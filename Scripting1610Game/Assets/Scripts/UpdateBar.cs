using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBar : MonoBehaviour
{

    private Image barImage;
    public floatData FillNumber;
    
    
    void Start()
    {
        barImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        barImage.fillAmount = FillNumber.Value;
    }
}
