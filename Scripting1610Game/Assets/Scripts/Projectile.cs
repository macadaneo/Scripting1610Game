using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Projectile : MonoBehaviour
{
    new Rigidbody rigidbody;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody.AddForce(direction * force);
    }

    private void OnCollisionEnter(Collision other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            e.Dead();
        }
        
        Destroy(gameObject);
        
        Debug.Log("Projectile Collision with " + other.gameObject);
        Destroy(gameObject);
    }

    private void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }
}
