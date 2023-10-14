using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraight : MonoBehaviour
{
    public Vector2 velocity;
    private Rigidbody2D objectRigidbody;

    private void Start()
    {
        this.objectRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        objectRigidbody.velocity = velocity;
    }
}
