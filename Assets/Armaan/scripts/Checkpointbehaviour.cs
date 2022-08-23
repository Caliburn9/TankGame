using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpointbehaviour : MonoBehaviour
{

    public AudioSource checkpointaudio;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        gameObject.SetActive(false);
        checkpointaudio.Play();
    }
}
