using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Circling : MonoBehaviour
{
    float angle = 0;
    float speed = (2 * Mathf.PI) / 5; //2*PI in degress is 360, so you get 5 seconds to complete a circle
    float radius = 5;
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        x = radius;
        y = 0;
        z = 0;
        transform.position = new Vector3(x, y, z);
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Time.deltaTime; //if you want to switch direction, use -= instead of +=
        x = Mathf.Cos(angle) * radius;
        y = 0;
        z = Mathf.Sin(angle) * radius;
        transform.position = new Vector3(x, y, z);
    }
}
