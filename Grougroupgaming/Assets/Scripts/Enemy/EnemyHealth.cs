using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    void OnTriggerEnter2D(Collider2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "PlayerDamage")
        {
            health--;
            Debug.Log("Enemy Health = " + health);
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}