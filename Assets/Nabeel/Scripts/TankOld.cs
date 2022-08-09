using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankOld : MonoBehaviour
{
    public float moveSpeed, rotationSpeed;
    public GameObject leftWheel, rightWheel;
    Rigidbody2D leftWheelBody, rightWheelBody;

    // Start is called before the first frame update
    void Start()
    {
        leftWheelBody = leftWheel.GetComponent<Rigidbody2D>();
        rightWheelBody = rightWheel.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.UpArrow))
        {
            leftWheelBody.AddForce(leftWheel.transform.up * moveSpeed);
            rightWheelBody.AddForce(rightWheel.transform.up * moveSpeed);
        } else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, 0, -rotationSpeed));
        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(0, 0, rotationSpeed));
        }

        //if (Input.GetKey(KeyCode.W))
        //{
        //    //Move left wheel forward
        //    leftWheelBody.AddForce(leftWheel.transform.up * moveSpeed);
        //    transform.Rotate(new Vector3(0, 0, rotationSpeed));
        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    //Move left wheel backward
        //    leftWheelBody.AddForce(-leftWheel.transform.up * moveSpeed);
        //}

        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    //Move right wheel forward
        //    rightWheelBody.AddForce(rightWheel.transform.up * moveSpeed);
        //    transform.Rotate(new Vector3(0, 0, -rotationSpeed));
        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    //Move right wheel backward
        //    rightWheelBody.AddForce(-rightWheel.transform.up * moveSpeed);
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    //Turn body left
        //    transform.Rotate(new Vector3(0, 0, rotationSpeed));
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    //Turn body right
        //    transform.Rotate(new Vector3(0, 0, -rotationSpeed));
        //}
    }
}
