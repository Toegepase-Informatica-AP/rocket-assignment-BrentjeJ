using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{

    float rotationLeftRight = 0;
    float rotationForwardBackward = 0;


    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            print("space key was pressed");
            transform.Translate(0, 0.03f, 0);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rotationLeftRight -= 0.001f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationLeftRight += 0.001f;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rotationLeftRight = 0;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rotationLeftRight = 0;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotationForwardBackward += 0.001f;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotationForwardBackward -= 0.001f;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rotationForwardBackward = 0;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rotationForwardBackward = 0;
        }


        transform.Rotate(rotationLeftRight, 0, rotationForwardBackward, Space.Self);
    }
}
