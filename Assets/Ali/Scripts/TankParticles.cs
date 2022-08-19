using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankParticles : MonoBehaviour
{
    public ParticleSystem ps;
    private ParticleSystem.EmissionModule em;

    void Start()
    {
        em = ps.emission;
    }

    public void StartEmit()
    {
        em.enabled = true;
    }

    public void StopEmit()
    {
        em.enabled = false;
    }
}
