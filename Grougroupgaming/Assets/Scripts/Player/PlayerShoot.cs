using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerShoot : MonoBehaviour
{
    public GameObject knife;

    public AudioClip shootSound;

    public float knifeSpeed = 50.0f;
    public float knifeLifetime = 1.0f;
    public float shootDelay = 1.0f;
    int knives = 10;

    float timer = 0;

    public TextMeshProUGUI knivesText;

    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire2"))
            {
                if (timer >= shootDelay)
                {
                    if (knives >= 1)
                    {
                        GameObject knifeSpawn = Instantiate(knife, transform.position, Quaternion.identity);
                        Vector3 mousePosition = Input.mousePosition;
                        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
                        Vector3 shootDir = mousePosition - transform.position;
                        shootDir.Normalize();
                        knifeSpawn.GetComponent<Rigidbody2D>().velocity = shootDir * knifeSpeed;
                        Destroy(knifeSpawn, knifeLifetime);
                        timer = 0;
                        knives--;
                        Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
                    }
                }
            }
        }
        knivesText.text = "Knives: " + knives;
    }
}
