using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D playerRigidbody;
    private Animator playerAnimator;

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    // FixedUpdate: wird x mal pro Sekunde aufgerufen -> Spiel läuft immer gleich schnell, unabhängig von der Geräteleistung
    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // 1=rechts, -1=links, 0=keine Bewegung
        float verticalInput = Input.GetAxis("Vertical"); // 1=vorwärts, -1=rückwärts, 0=keine Bewegung

        Vector2 direction = new Vector2(horizontalInput, verticalInput);
        this.playerRigidbody.velocity = direction.normalized * speed; // um diagonale Bewegungen genauso schnell wie gerade Bewegungen zu machen

        this.playerAnimator.SetBool("isFlyingLeft", horizontalInput < 0);
        this.playerAnimator.SetBool("isFlyingRight", horizontalInput > 0);
        this.playerAnimator.SetBool("isFlyingBack", verticalInput < 0);
    }

    private void OnDisable()
    {
        SceneManager.LoadScene(0);
    }
}
