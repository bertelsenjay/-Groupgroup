using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    void OnCollisionEnter2D(Collision2D collision)
    {
        string otherTag = collision.gameObject.tag;
        if (otherTag == "PlayerDamage")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}