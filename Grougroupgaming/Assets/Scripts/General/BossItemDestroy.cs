using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossItemDestroy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
