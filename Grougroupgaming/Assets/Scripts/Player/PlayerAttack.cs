using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private Animator attackAnim;
    public GameObject attack;
    public float attackLifetime = 1.0f;
    public AudioClip attackSound;
    float timer = 0;
    public float attackDelay = 1.0f;
    void Start()
    {
        attackAnim = GetComponent<Animator>();
    }
    void Update()
    {
        if (Time.timeScale == 1)
        {
            timer += Time.deltaTime;
            if (Input.GetButton("Fire1"))
            {
                if (timer >= attackDelay)
                {
                    GameObject attackSpawn = Instantiate (attack, transform.position, Quaternion.identity);
                    Debug.Log("1");
                    Destroy(attackSpawn, attackLifetime);
                    Camera.main.GetComponent<AudioSource>().PlayOneShot(attackSound);
                    timer = 0;
                }
            }
        }
    }
    public void playAnimation (string name)
    {
        attackAnim.Play(name);
    }
}
