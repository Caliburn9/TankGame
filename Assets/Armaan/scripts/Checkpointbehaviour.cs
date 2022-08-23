using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpointbehaviour : MonoBehaviour
{

    public AudioSource checkpointaudio;
    public GameObject visual;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        checkpointaudio.Play();
    
        visual.gameObject.SetActive(false);
    }

}
