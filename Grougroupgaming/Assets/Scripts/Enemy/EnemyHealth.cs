using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    void OnTriggerEnter2D(Collider2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "PlayerDamage")
        {
            health--;
            if (health <= 0)
            {
                Kill();
            }
        }
    }

    void Kill()
    {
        Destroy(gameObject);
        if (gameObject.tag == "Boss")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}