using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSound : MonoBehaviour
{
    public AudioSource TankEngine;
    public AudioSource TankAcc;

    public AudioSource[] sources;
    void Start()
    {
        sources = GetComponents<AudioSource>();
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            sources[0].enabled = true;
        }

        else
        {
            sources[0].enabled = false;
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.UpArrow)) //|| Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            sources[1].enabled = true;
            sources[0].enabled = false;
        }

        else
        {
            sources[1].enabled = false;

        }
    }
}
