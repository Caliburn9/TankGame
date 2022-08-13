using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBulletSpawn : MonoBehaviour
{
    public GameObject bullet;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(bulletspawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator bulletspawn()
    {
        while (true)
        {
            Instantiate(bullet,transform.position , transform.rotation);
            yield return new WaitForSeconds(timer);
        }
        
    }


}
