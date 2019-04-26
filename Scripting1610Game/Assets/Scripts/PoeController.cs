using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoeController : MonoBehaviour
{
    public float speed = 3.0f;
    
     public int maxHealth = 5;

     public int health{get {return currentHealth;}}
     private int currentHealth;

     public Rigidbody rigidbody;

        public void Start()
        {
          rigidbody = GetComponent<Rigidbody>();
  
          currentHealth = maxHealth;
        }


        public void Update()
        {
          float horizontal = Input.GetAxis("Horizontal");
          float vertical = Input.GetAxis("Vertical");
          
          Vector2 position = rigidbody.position;
          position.x = position.x + 3.0f* horizontal * Time.deltaTime;
          position.y = position.y + 3.0f * vertical * Time.deltaTime;
          
          
          rigidbody.MovePosition(position);
        }

        public void ChangeHealth(int amount)
        {
          currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
          Debug.Log(currentHealth + "/" + maxHealth);
        }
}
