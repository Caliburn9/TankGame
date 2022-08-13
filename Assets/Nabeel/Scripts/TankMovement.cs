using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public float moveSpeed, rotationSpeed;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Forward movement and rotation
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * moveSpeed);
        } else if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(0, 0, -rotationSpeed));
        } else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(0, 0, rotationSpeed));
        }

        //Backward movement and rotation
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.up * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(0, 0, rotationSpeed));
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(0, 0, -rotationSpeed));
        }
    }
}
