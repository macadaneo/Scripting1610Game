using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        PoeController controller = other.GetComponent<PoeController >();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
        }
    }

}
