using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float moveSpeed, rotationSpeed;
    public GameObject[] lights;
    float leftMove, rightMove;
    TankMovement moveScript;
    TankSound soundScript;
    TankParticles particleScript;

    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<TankMovement>();
        soundScript = GetComponent<TankSound>();
        particleScript = GetComponent<TankParticles>();
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
            soundScript.PlaySound(0);
            soundScript.PlaySound(1);
            particleScript.StartEmit();

            lights[0].gameObject.SetActive(true);
            lights[1].gameObject.SetActive(true);
        }

        //Backward movement
        if (leftMove < 0 && rightMove < 0)
        {
            moveScript.Move(-moveSpeed);
            soundScript.PlaySound(0);
            soundScript.PlaySound(1);
            particleScript.StartEmit();

            lights[2].gameObject.SetActive(true);
            lights[3].gameObject.SetActive(true);
        }

        //Left rotation
        if (leftMove < 0 && rightMove > 0)
        {
            moveScript.Rotate(rotationSpeed);
            soundScript.PlaySound(0);
            particleScript.StartEmit();

            lights[0].gameObject.SetActive(true);
            lights[3].gameObject.SetActive(true);
        }

        //Right rotation
        if (leftMove > 0 && rightMove < 0)
        {
            moveScript.Rotate(-rotationSpeed);
            soundScript.PlaySound(0);
            particleScript.StartEmit();

            lights[1].gameObject.SetActive(true);
            lights[2].gameObject.SetActive(true);
        }

        //Stop playing sound when not pressing button
        if (leftMove == 0 && rightMove == 0)
        {
            soundScript.StopSound(0);
            soundScript.StopSound(1);
            particleScript.StopEmit();

            for (int i = 0; i < lights.Length; i++)
            {
                lights[i].gameObject.SetActive(false);
            }
        }
    }
}
