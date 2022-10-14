using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject attack;
    public float attackLifetime = 1.0f;
    //public AudioClip attackSound;
    float timer = 0;
    public float attackDelay = 0;
    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire1"))
            {
                if (timer >= attackDelay)
                {
                    GameObject attackSpawn = Instantiate(attack, transform.position, Quaternion.identity);
                    Debug.Log("1");
                    Destroy(attackSpawn, attackLifetime);
                    //Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
                    timer = 0;
                }
                
            }
        }
    }
}
