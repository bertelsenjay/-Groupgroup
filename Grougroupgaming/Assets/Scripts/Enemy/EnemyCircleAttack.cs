using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCircleAttack : MonoBehaviour
{
    public GameObject player;

    public GameObject attack;

    public float attackLifetime = 1.0f;
    public float attackDelay = 1.0f;
    public float close = 0.5f;
    float timer = 0;
    bool attackRight;

    public AudioSource audioSource;
    public AudioClip attackSound;

    public Animator animator;

    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            Vector3 Dir = player.transform.position - transform.position;
            float Dist = Dir.magnitude;
            Dir.Normalize();
            if (Dist <= close)
            {
                if (timer >= attackDelay)
                {
                    Attack();
                }
            }
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
        GameObject attackSpawn = Instantiate(attack, transform.position, Quaternion.identity);
        Destroy(attackSpawn, attackLifetime);
        audioSource.PlayOneShot(attackSound, 1.0f);
        timer = 0;
    }
}
