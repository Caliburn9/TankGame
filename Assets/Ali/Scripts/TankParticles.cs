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

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            em.enabled = true;
        }

        

        else
        {
            em.enabled = false;
        }
    }
}
