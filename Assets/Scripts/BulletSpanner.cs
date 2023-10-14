using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpanner : MonoBehaviour
{
    public GameObject bullet;
    public float spanIntervalInSeconds = 1f;
    public float initalSpanningAfterSeconds = 1f; 

    private void Start()
    {
        InvokeRepeating("CreateBullet", initalSpanningAfterSeconds, spanIntervalInSeconds);
    }

    private void CreateBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
