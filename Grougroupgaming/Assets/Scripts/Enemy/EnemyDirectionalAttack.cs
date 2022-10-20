using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDirectionalAttack : MonoBehaviour
{
    public GameObject player;

    public GameObject attack;

    public float attackLifetime = 1.0f;
    public float attackDelay = 3.0f;
    public float close = 2.0f;
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
                    if (Dir.x >= 0)
                    {
                        attackRight = true;
                        Attack();
                    }
                    else
                    {
                        attackRight = false;
                        Attack();
                    }
                }
            }
        }
    }

    void Attack()
    {
        Debug.Log("ATTACKING");
        Vector3 attackVector = (transform.position);
        Vector3 rightVector = attackVector += Vector3.right;
        Vector3 leftVector = attackVector += Vector3.left;
        rightVector = rightVector += Vector3.right;
        leftVector = leftVector += Vector3.left;
        animator.SetTrigger("Attack");
        if (attackRight)
        {
            Debug.Log("1");
            GameObject attackSpawn = Instantiate(attack, rightVector, Quaternion.identity);
            attackSpawn.transform.Rotate(0, 0, 90);
            Destroy(attackSpawn, attackLifetime);
        }
        else
        {
            Debug.Log("2");
            GameObject attackSpawn = Instantiate(attack, leftVector, Quaternion.identity);
            attackSpawn.transform.Rotate(0, 0, 90);
            Destroy(attackSpawn, attackLifetime);
        }
        audioSource.PlayOneShot(attackSound, 1.0f);
        timer = 0;
    }
}
