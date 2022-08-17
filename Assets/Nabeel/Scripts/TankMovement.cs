using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class TankMovement : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void Move(float speedVal) {
        rb.AddForce(transform.up * speedVal);
    }
    
    public void Rotate(float rotVal) {
        transform.Rotate(new Vector3(0, 0, rotVal));
    }
}
