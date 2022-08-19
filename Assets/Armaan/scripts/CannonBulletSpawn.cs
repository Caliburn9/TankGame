using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public float timer;
    public AudioSource BulletSpawnAudio;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bulletspawn());
    }

    IEnumerator bulletspawn()
    {
        while (true)
        {
            Instantiate(bullet,transform.position , transform.rotation);
            BulletSpawnAudio.Play();
            yield return new WaitForSeconds(timer);
        }
        
    }


}
