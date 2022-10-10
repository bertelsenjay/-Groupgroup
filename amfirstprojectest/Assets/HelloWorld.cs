using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        string name = "GD15";
        // Starting integer for health.
        int health = 10;
        // Next four lines mean the same thing. Subtract 2 from the health.
        health = health - 2;
        health -= 2;
        health++;
        health--;
        // Creates decimal values like percentages.
        float critChance = 0.6f;
        // Is a true or false, determines condition.
        bool alive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
