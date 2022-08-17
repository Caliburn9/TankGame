using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float moveSpeed, rotationSpeed;
    float leftMove, rightMove;
    TankMovement moveScript;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<TankMovement>();
    }

    private void Awake()
    {
        leftMove = 0;
        rightMove = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Get Axes
        leftMove = Input.GetAxis("LeftMovement");
        rightMove = Input.GetAxis("RightMovement");

        //Forward movement
        if (leftMove > 0 && rightMove > 0)
        {
            moveScript.Move(moveSpeed);
        }

        //Backward movement
        if (leftMove < 0 && rightMove < 0)
        {
            moveScript.Move(-moveSpeed);
        }

        //Left rotation
        if (leftMove < 0 && rightMove > 0)
        {
            moveScript.Rotate(rotationSpeed);
        }

        //Right rotation
        if (leftMove > 0 && rightMove < 0)
        {
            moveScript.Rotate(-rotationSpeed);
        }

        ////Forward movement
        //if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.UpArrow))
        //{
        //    moveScript.Move(moveSpeed);
        //}

        ////Backward movement
        //if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.DownArrow))
        //{
        //    moveScript.Move(-moveSpeed);
        //}

        ////Left rotation
        //if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow))
        //{
        //    moveScript.Rotate(rotationSpeed);
        //}

        ////Right rotation
        //if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.DownArrow))
        //{
        //    moveScript.Rotate(-rotationSpeed);
        //}
    }
}
