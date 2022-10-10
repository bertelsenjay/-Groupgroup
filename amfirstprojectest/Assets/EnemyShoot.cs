using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed = 8.0f;
    public float bulletLifetime = 1.0f;
    public GameObject player;
    public float close = 5.0f;
    float timer = 0;
    public float shootDelay = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDir = player.transform.position - transform.position;
        float shootDist = shootDir.magnitude;
        shootDir.Normalize();
        if (shootDist <= close)
        {
            Debug.Log("close");
           if(timer >= shootDelay)
            {
                Debug.Log("shoot");
                timer = 0;
                GameObject bulletSpawn = Instantiate(bullet, transform.position, Quaternion.identity);
                bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
                Destroy(bulletSpawn, bulletLifetime);
            }
        }
    }
}
