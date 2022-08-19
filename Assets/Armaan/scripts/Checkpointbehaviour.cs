using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpointbehaviour : MonoBehaviour
{
    public AudioSource checkpointaudio;

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        checkpointaudio.Play();
    }
}
