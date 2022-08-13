using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_vision : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

            Instantiate(bullet, transform.position, transform.rotation);
        

    }

}
