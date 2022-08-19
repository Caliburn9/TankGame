using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSound : MonoBehaviour
{
    AudioSource[] sources;
    
    void Start()
    {
        sources = GetComponents<AudioSource>();
    }

    public void PlaySound(int index)
    {
        sources[index].Play();
    }

    public void StopSound(int index)
    {
        sources[index].Stop();
    }
}
