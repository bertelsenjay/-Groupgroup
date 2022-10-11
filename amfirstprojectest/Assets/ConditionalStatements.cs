using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalStatements : MonoBehaviour
{
    int level = 1;
    public int xp = 0;
    public int levelUpXP = 50;
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        // Double equal sign asks if things are equal. single equal sign makes it equal.
        if (xp >= levelUpXP)
        {
            level++;
            xp = xp - levelUpXP;
            levelUpXP += 50;
            Debug.Log("Holy awesome you just reached level "+ level);
        }
    }
}
