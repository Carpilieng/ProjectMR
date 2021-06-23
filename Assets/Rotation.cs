using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float speed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(GameObject.Find("Cube").transform.position);
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
