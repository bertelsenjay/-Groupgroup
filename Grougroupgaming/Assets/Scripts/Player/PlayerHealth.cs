using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class PlayerHealth : MonoBehaviour
{
    public int health = 5;
    public TextMeshProUGUI healthText;

    void Update()
    {
        healthText.text = "Health: " + health;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "Enemy")
        {
            takeDamage();
        }
        else if (otherTag == "EnemyDamage")
        {
            takeDamage();
        }
        else if (otherTag == "Boss")
        {
            takeDamage();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "EnemyDamage")
        {
            takeDamage();
        }
        else if (otherTag == "BossDamage")
        {
            takeDamage();
        }
        else if (otherTag == "HealingItem")
        {
            health++;
        }
    }

    void takeDamage()
    {
        health--;
        if (health <= 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }
}