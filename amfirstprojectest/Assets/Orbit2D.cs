using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit2D : MonoBehaviour
{
    public GameObject target;
    public float speed = 10;
    public Vector3 direction = Vector3.up;

    void Update()
    {
        transform.RotateAround(target.transform.position, direction, speed * Time.deltaTime);
    }
}
