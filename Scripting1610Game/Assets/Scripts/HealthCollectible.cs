using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        PoeController controller = other.GetComponent<PoeController>();

        if (controller!= null)
        {
            if (controller.currentHealth < controller.maxHealth)
            {
                controller.currentHealth(1);
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
