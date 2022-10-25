using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterMove : MonoBehaviour
{
    public GameObject player;

    public float close = 15.0f;
    public float speed = 2.0f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 chaseDir;

    void Update()
    {
        chaseDir = player.transform.position - transform.position;
        float chaseDist = chaseDir.magnitude;
        chaseDir.Normalize();

        if (chaseDist >= close)
        {
            rb.MovePosition(rb.position + chaseDir * speed * Time.fixedDeltaTime);
            animator.SetFloat("Horizontal", chaseDir.x);
            animator.SetFloat("Vertical", chaseDir.y);
            animator.SetFloat("Speed", chaseDir.magnitude);
        }
        else
        {
            rb.MovePosition(rb.position + chaseDir * 0);
        }
    }
}
