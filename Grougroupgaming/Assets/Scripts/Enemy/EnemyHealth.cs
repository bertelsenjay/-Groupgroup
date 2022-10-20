using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    void OnTriggerEnter2D(Collider2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "PlayerDamage")
        {
            health--;
            Debug.Log(health);
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}