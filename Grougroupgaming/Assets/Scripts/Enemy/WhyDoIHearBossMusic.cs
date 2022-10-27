using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhyDoIHearBossMusic : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D collision)
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play(0);
    }
}
