using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankRespawn : MonoBehaviour
{
    Transform checkpointLocation;
    
    public bool checkpoint = false;

    ParticleSystem deathExplosion;
    TankSound soundScript;
    public float deathTimer;

    private void Start()
    {
        deathExplosion = GetComponent<ParticleSystem>();
        soundScript = GetComponent<TankSound>();
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
            StartCoroutine(Death());
        }
    }

    IEnumerator Death()
    {
        deathExplosion.Play();
        soundScript.PlaySound(2);
        yield return new WaitForSeconds(deathTimer);
        if (checkpoint == true)
        {
            transform.position = checkpointLocation.position;
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
