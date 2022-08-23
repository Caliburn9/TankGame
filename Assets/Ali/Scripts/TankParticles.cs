using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankParticles : MonoBehaviour
{
    public ParticleSystem ps;

    public void StartEmit()
    {
        ps.Play();
    }

    public void StopEmit()
    {
        ps.Stop();
    }
}
