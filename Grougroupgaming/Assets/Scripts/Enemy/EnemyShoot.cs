using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject player;
    public GameObject arrow;

    public float arrowSpeed = 8.0f;
    public float arrowLifetime = 1.0f;
    public float shootDelay = 0;

    public float close = 5.0f;
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDir = player.transform.position - transform.position;
        float shootDist = shootDir.magnitude;
        shootDir.Normalize();
        if (shootDist <= close)
        {
            Debug.Log("close");
            if (timer >= shootDelay)
            {
                Debug.Log("shoot");
                timer = 0;
                GameObject bulletSpawn = Instantiate(arrow, transform.position, Quaternion.identity);
                bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * arrowSpeed;
                Destroy(bulletSpawn, arrowLifetime);
            }
        }
    }
}