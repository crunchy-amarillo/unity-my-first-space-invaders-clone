using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpanner : MonoBehaviour
{
    public GameObject monster1;
    public GameObject monster2;
    public float spawnIntervalInSeconds = 3f;
    public float initalSpanningAfterSeconds = 1f;

    private void Start()
    {

        InvokeRepeating("SpawnMonster", initalSpanningAfterSeconds, spawnIntervalInSeconds);
    }

    private void SpawnMonster()
    {
        float randomFactor = Random.value;

        if (randomFactor < 0.2)
        {
            Instantiate(monster1, transform.position, Quaternion.identity);
        } else if (randomFactor < 0.4) {
            Instantiate(monster2, transform.position, Quaternion.identity);
        }
    }
}
