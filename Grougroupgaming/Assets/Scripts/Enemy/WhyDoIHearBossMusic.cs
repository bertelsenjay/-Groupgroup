using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhyDoIHearBossMusic : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bossMusic;

    void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(bossMusic, 9000f);
    }
}
