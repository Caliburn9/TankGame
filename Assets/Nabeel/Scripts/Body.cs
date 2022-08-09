using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    GameObject[] wheel;
    public Transform focalPoint;

    private void Start()
    {
        wheel = GameObject.FindGameObjectsWithTag("Wheel");
        for (int i = 0; i < wheel.Length; i++)
        {
            Physics2D.IgnoreCollision(wheel[i].gameObject.GetComponent<BoxCollider2D>(), GetComponent<BoxCollider2D>());
        }
    }

    private void Update()
    {
        transform.position = focalPoint.transform.position;
    }
}
