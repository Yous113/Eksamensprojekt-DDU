using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
   public float health = 10f;

   public void TakeDamage (float amount)
   {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
   }
   void Die()
   {
        Destroy(gameObject);
   }
}