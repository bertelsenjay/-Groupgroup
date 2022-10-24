using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attack;

    public float attackLifetime = 1.0f;
    public float attackDelay = 1.0f;
    float timer = 0;

    public AudioSource audioSource;
    public AudioClip attackSound;

    public Animator animator;

    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire1"))
            {
                Attack();
            }
        }
    }

    void Attack()
    {
        if (timer >= attackDelay)
        {
            animator.SetTrigger("Attack");
            GameObject attackSpawn = Instantiate(attack, transform.position, Quaternion.identity);
            Destroy(attackSpawn, attackLifetime);
            audioSource.PlayOneShot(attackSound, 1.0f);
            timer = 0;
        }
    }
}
