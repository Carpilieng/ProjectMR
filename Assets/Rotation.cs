using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotation : MonoBehaviour
{
    Vector3 myVector;
    public float x_cam, y_cam, z_cam;   
    public float angle1, angle2, angle3;
    // Start is called before the first frame update
    void Start()
    {
        myVector = GameObject.Find("Main Camera").transform.position;
        x_cam = myVector.x;
        y_cam = myVector.y;
        z_cam = myVector.z;
        angle3 = (float)Math.Atan2(y_cam, x_cam);
        angle2 = (float)Math.Atan2(z_cam, x_cam);
        angle1 = (float)Math.Atan2(z_cam, y_cam);
        transform.Rotate(angle1,angle2,angle3);
    }

    // Update is called once per frame
    void Update()
    {
        myVector = GameObject.Find("Main Camera").transform.position;
        Debug.Log(myVector);
        x_cam = myVector.x;
        y_cam = myVector.y;
        z_cam = myVector.z;
        if (x_cam == 0)
        {
            angle3 = 0;
            angle2 = 0;
            angle1 = (float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
        }
        if (y_cam == 0)
        {
            angle3 = (float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
            angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
            angle1 = 0;
            transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
        }
        else if (x_cam*y_cam!=0)
        {
            if ((x_cam * y_cam >= 0) && (x_cam * z_cam >= 0) && (y_cam * z_cam >= 0))
            {
                angle3 = (float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
                angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
                angle1 = (float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
            }
            if ((x_cam * y_cam >= 0) && (x_cam * z_cam >= 0) && (y_cam * z_cam <= 0))
            {
                angle3 = (float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
                angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
                angle1 = -(float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
            }
            if ((x_cam * y_cam >= 0) && (x_cam * z_cam <= 0) && (y_cam * z_cam >= 0))
            {
                angle3 = (float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
                angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
                angle1 = (float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
            }
            if ((x_cam * y_cam >= 0) && (x_cam * z_cam <= 0) && (y_cam * z_cam <= 0))
            {
                angle3 = (float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
                angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
                angle1 = -(float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
            }
            if ((x_cam * y_cam <= 0) && (x_cam * z_cam >= 0) && (y_cam * z_cam >= 0))
            {
                angle3 = -(float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
                angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
                angle1 = (float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
            }
            if ((x_cam * y_cam <= 0) && (x_cam * z_cam >= 0) && (y_cam * z_cam <= 0))
            {
                angle3 = -(float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
                angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
                angle1 = -(float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
            }
            if ((x_cam * y_cam <= 0) && (x_cam * z_cam <= 0) && (y_cam * z_cam >= 0))
            {
                angle3 = -(float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
                angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
                angle1 = (float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
            }
            if ((x_cam * y_cam <= 0) && (x_cam * z_cam <= 0) && (y_cam * z_cam <= 0))
            {
                angle3 = -(float)Math.Atan2(y_cam, x_cam) * Mathf.Rad2Deg;
                angle2 = -(float)Math.Atan2(z_cam, x_cam) * Mathf.Rad2Deg;
                angle1 = -(float)Math.Atan2(z_cam, y_cam) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(angle1, angle2, angle3));
            }
        }
    }
}
