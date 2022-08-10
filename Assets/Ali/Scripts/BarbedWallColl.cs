using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BarbedWallColl : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Barbedwall")
        {
            SceneManager.LoadScene(1);

        }
        if (collision.tag == "Cross")
        {
            SceneManager.LoadScene(1);

        }
    }
}
