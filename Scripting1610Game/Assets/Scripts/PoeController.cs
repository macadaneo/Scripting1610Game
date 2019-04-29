using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class PoeController : MonoBehaviour
{
    public float speed = 3.0f;
    
     public int maxHealth = 5;
     public int health{get {return currentHealth;}}
     int currentHealth;
     float timeInvincible = 2.0f;
     bool isInvincible;
     float invincibleTimer;
     public GameObject projectilePrefab;

     public new Rigidbody rigidbody;

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

          if (isInvincible)
          {
            invincibleTimer -= Time.deltaTime;
            if (invincibleTimer < 0)
              isInvincible = false;
          }

          if (Input.GetKeyDown(KeyCode.C))
          {
            Launch();
          }
        }

        public void ChangeHealth(int amount)
        {
          if (amount < 0)
          {
            if (isInvincible)
              return;
            isInvincible = true;
            invincibleTimer = timeInvincible;

          }
          
          currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
          Debug.Log(currentHealth + "/" + maxHealth);
          UIHealthBar.instance.SetValue(currentHealth / (float) maxHealth);
        }

        public void Launch()
        {
            GameObject projectileObject = Instantiate(projectilePrefab, rigidbody.position / Vector2.up / 0.5f, Quaternion.identity);
        
            Projectile projectile = projectileObject.GetComponent<Projectile>();
            projectile.Launch(Vector2.left,3000);  
        }
        
        
        
}
