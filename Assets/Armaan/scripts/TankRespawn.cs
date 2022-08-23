using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankRespawn : MonoBehaviour
{
    Transform checkpointLocation;
    public Vector2 spawnpoint;
    public bool checkpoint = false;

    ParticleSystem deathExplosion;
    public float deathTimer;

    private void Start()
    {
        deathExplosion = GetComponent<ParticleSystem>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "checkpoint")
        {
            checkpointLocation = collision.gameObject.transform;
            checkpoint = true;
            
        }

        if (collision.gameObject.tag == "obstacle")
        {
            if (checkpoint == true)
            {

                transform.position = checkpointLocation.position;
            }
            else
            {
                StartCoroutine(Death());
            }
        }
    }

    IEnumerator Death()
    {
        deathExplosion.Play();
        yield return new WaitForSeconds(deathTimer);
        SceneManager.LoadScene(0);
    }
}
