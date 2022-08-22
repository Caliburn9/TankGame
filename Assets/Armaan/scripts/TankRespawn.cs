using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankRespawn : MonoBehaviour
{
    public Vector2 spawnpoint;
    bool checkpoint = false;
    TankSound soundScript;

    ParticleSystem deathExplosion;
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
            checkpoint = true;
        }

        if (collision.gameObject.tag == "obstacle")
        {
            if (checkpoint == true)
            {
                transform.position = new Vector2(spawnpoint.x, spawnpoint.y);
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
        soundScript.PlaySound(2);
        yield return new WaitForSeconds(deathTimer);
        SceneManager.LoadScene(0);
    }
}
