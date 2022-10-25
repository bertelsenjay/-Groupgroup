using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Animator animator;

    public GameObject player;
    public GameObject arrowUp;
    public GameObject arrowRight;
    public GameObject arrowLeft;
    public GameObject arrowDown;

    public float arrowSpeed = 8.0f;
    public float arrowLifetime = 1.0f;
    public float shootDelay = 2.0f;

    public float close = 12.0f;
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDir = player.transform.position - transform.position;
        float shootAngle = Vector3.Angle(shootDir, transform.up);
        float shootDist = shootDir.magnitude;
        shootDir.Normalize();
        if (shootDist <= close)
        {
            if (timer >= shootDelay)
            {
                animator.SetTrigger("Attack");
                if (shootAngle <= 45)
                {
                    GameObject bulletSpawn = Instantiate(arrowUp, transform.position, Quaternion.identity);
                    bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * arrowSpeed;
                    Destroy(bulletSpawn, arrowLifetime);
                }
                else if (shootAngle >= 135)
                {
                    GameObject bulletSpawn = Instantiate(arrowDown, transform.position, Quaternion.identity);
                    bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * arrowSpeed;
                    Destroy(bulletSpawn, arrowLifetime);
                }
                else if (shootDir.x >= 0)
                {
                    GameObject bulletSpawn = Instantiate(arrowRight, transform.position, Quaternion.identity);
                    bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * arrowSpeed;
                    Destroy(bulletSpawn, arrowLifetime);
                }
                else
                {
                    GameObject bulletSpawn = Instantiate(arrowLeft, transform.position, Quaternion.identity);
                    bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * arrowSpeed;
                    Destroy(bulletSpawn, arrowLifetime);
                }
                timer = 0;
            }
        }
    }
}