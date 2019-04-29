using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;
    public bool alive = true;
    public ParticleSystem smokeEffect;

    new Rigidbody rigidbody;
    float timer;
    int direction = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        timer = changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!alive)
        {
            return;
        }
        
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }
        
        
        Vector2 position = rigidbody.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
        }
 
        rigidbody.MovePosition(position);
    }

     void OnCollisionEnter(Collision other)
    {
        PoeController player = other.gameObject.GetComponent<PoeController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }

     public void Dead()
     {
         alive = false;
         Destroy(gameObject);
     }
}
