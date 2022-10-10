using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
        void OnCollisionEnter2D(Collision2D collision)
        {
            string otherTag = collision.gameObject.tag;
            if (otherTag == "EnemyHarm")
            {
                health--;
                if (health <= 0)
            {
                Destroy(gameObject);
            }
                
            }
        }
}
