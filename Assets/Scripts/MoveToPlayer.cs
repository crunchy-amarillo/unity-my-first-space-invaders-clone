using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public float speed = 1f;

    private void Start()
    {
        GameObject playerObject = GameObject.FindWithTag("Player");

        if (null == playerObject)
        {
            return;
        }

        Vector3 direction2d = (playerObject.transform.position - transform.position).normalized;
        Vector2 direction = new Vector2(direction2d.x, direction2d.y);
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
