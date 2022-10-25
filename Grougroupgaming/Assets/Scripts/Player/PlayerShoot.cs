using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject knife;

    public AudioClip shootSound;

    public float knifeSpeed = 5.0f;
    public float knifeLifetime = 1.0f;
    public float shootDelay = 0;

    float timer = 0;

    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire2"))
            {
                if (timer >= shootDelay)
                {
                    GameObject knifeSpawn = Instantiate(knife, transform.position, Quaternion.identity);
                    Vector3 mousePosition = Input.mousePosition;
                    mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                    Vector3 shootDir = mousePosition - transform.position;
                    shootDir.Normalize();
                    knifeSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * knifeSpeed;
                    Destroy(knifeSpawn, knifeLifetime);
                    Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
                    timer = 0;
                }

            }
        }
    }
}
