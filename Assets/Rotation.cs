using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Rotation : MonoBehaviour
{
    Vector3 myVector;
    public float x_cam, y_cam, z_cam;
    public float x_cam_1, y_cam_1, z_cam_1;
    public float angle1, angle2, angle3;
    // Start is called before the first frame update
    void Start()
    {
        myVector = GameObject.Find("Main Camera").transform.position;
        x_cam = myVector.x;
        y_cam = myVector.y;
        z_cam = myVector.z;
        angle1 = (float)Math.Atan(y_cam / x_cam);
        angle2 = (float)Math.Atan(z_cam / x_cam);
        angle3 = (float)Math.Atan(z_cam / y_cam);
        transform.Rotate(angle1,angle2,angle3);
    }

    // Update is called once per frame
    void Update()
    {
        myVector = GameObject.Find("Main Camera").transform.position;
        x_cam_1 = myVector.x;
        y_cam_1 = myVector.y;
        z_cam_1 = myVector.z;
        if ((x_cam_1 - x_cam)*(y_cam_1 - y_cam)!=0) {
            angle1 = (float)Math.Atan((y_cam_1 - y_cam) / (x_cam_1 - x_cam));
            angle2 = (float)Math.Atan((z_cam_1 - z_cam) / (x_cam_1 - x_cam));
            angle3 = (float)Math.Atan((z_cam_1 - z_cam) / (y_cam_1 - y_cam));
        }
        transform.Rotate(angle1, angle2, angle3);
        x_cam = myVector.x;
        y_cam = myVector.y;
        z_cam = myVector.z;
    }
}
