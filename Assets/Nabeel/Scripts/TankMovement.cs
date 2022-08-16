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
        //Forward movement
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.UpArrow))
        {
            Move(moveSpeed);
        }

        //Backward movement
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.DownArrow))
        {
            Move(-moveSpeed);
        }

        //Left rotation
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow))
        {
            Rotate(rotationSpeed);
        }

        //Right rotation
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow))
        {
             Rotate(-rotationSpeed);
        }
    }
    
    void Move(float speedVal) {
        rb.AddForce(transform.up * speedVal);
    }
    
    void Rotate(float rotVal) {
        transform.Rotate(new Vector3(0, 0, rotVal));
    }
}
