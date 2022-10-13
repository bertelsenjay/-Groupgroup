using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackLifetime = 0.0f;
    //public AudioClip attackSound;
    float timer = 0;
    public float attackDelay = 1.0f;
    void Start()
    {
        GetComponent<CircleCollider2D>().enabled = false;
    }
    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetMouseButtonDown(0) && timer >= attackDelay)
            {
                GetComponent<CircleCollider2D>().enabled = true;
            }
            if (Input.GetMouseButtonDown(1))
            {
                GetComponent<CircleCollider2D>().enabled = false;
            }
        }
    }
}
