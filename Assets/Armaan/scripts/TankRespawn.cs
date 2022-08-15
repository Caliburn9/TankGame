using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TankRespawn : MonoBehaviour
{
    public Vector2 spawnpoint;
    bool checkpoint = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
                SceneManager.LoadScene(0);
            }
        }
    }
}
