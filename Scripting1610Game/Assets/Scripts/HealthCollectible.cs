using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
        PoeController controller = other.GetComponent<PoeController>();
   
        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
   			controller.ChangeHealth(1);
   			Destroy(gameObject);
			}
        }
   }
}

