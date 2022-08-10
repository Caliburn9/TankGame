using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class movement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private Vector2 moveInput;

    [SerializeField]
    float moveSpeed = 3f;

    
   
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;
    }
    
}
