using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float speedX;
    public int directionX;
    public float speedY;
    public int directionY;
    private Rigidbody2D _compRigidBody;
    private SpriteRenderer _compSpriteRenderer;

    private void Awake()
    {
        _compRigidBody = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        _compRigidBody.velocity = new Vector2(speedX * directionX, speedY * directionY );
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "vertical")
        {
            if (directionX == 1)
            {
                directionX = -1;
                _compSpriteRenderer.flipX = true;
            } 
            else if (directionX == -1)
            {
                directionX = 1;
                _compSpriteRenderer.flipX = false;
            }
        }
        if(collision.gameObject.tag == "horizontal")
        {
            if(directionY == 1)
            {
                directionY = -1;
                _compSpriteRenderer.flipY = true;
            }
            else if(directionY == -1)
            {
                directionY = 1;
                _compSpriteRenderer.flipY = false;
            }
        }
    }
}
