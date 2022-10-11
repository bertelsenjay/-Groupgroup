using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed = 5.0f;
    public float bulletLifetime = 1.0f;
    public AudioClip shootSound;
    float timer = 0;
    public float shootDelay = 0;

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire1"))
            {
                if (timer >= shootDelay)
                {
                    GameObject bulletSpawn = Instantiate(bullet, transform.position, Quaternion.identity);
                    //bulletSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 0);
                    Vector3 mousePosition = Input.mousePosition;
                    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                    Vector3 shootDir = mousePosition - transform.position;
                    shootDir.Normalize();
                    bulletSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
                    Destroy(bulletSpawn, bulletLifetime);
                    Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
                    timer = 0;
                }

            }
        }
    }
}
