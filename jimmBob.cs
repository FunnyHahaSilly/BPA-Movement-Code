using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jimmBob : MonoBehaviour
{
    public float playerspeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent < Rigidbody2D>();
    }


    void Update()
    {

        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");

        playerDirection = new Vector2(directionX, directionY).normalized;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirection.x * playerDirection.y * playerspeed);
    }
}
