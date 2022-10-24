using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public Collider2D NextLevelCollider;

    /*void Update()
    {
        
    }*/

    void OnTriggerEnter2D(Collider2D other)
    {
        string otherTag = other.gameObject.tag;
        if (otherTag == "Player")
        {
            Scene scene = SceneManager.GetActiveScene();
            int nextSceneIndex = scene.buildIndex;
            nextSceneIndex++;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
