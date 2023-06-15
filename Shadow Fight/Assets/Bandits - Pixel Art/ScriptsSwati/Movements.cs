using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public Animator animator;
    private new Camera camera;
    private new Rigidbody2D rigidbody;
    public float moveSpeed = 8f;
    private Vector2 velocity;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    private void Update()
    {
        HorizontalMovement();

        animator.SetFloat("Speed", Mathf.Abs(velocity.x));

        if (velocity.x < 0f)
        {
            transform.eulerAngles = Vector3.zero;
        }
        else if (velocity.x > 0f)
        {
            transform.eulerAngles = new Vector3(0f, 180f, 0f);
        }
    }

    private void HorizontalMovement()
    {
        float inputAxis = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            inputAxis = -1f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            inputAxis = 1f;
        }

        velocity.x = Mathf.MoveTowards(velocity.x, inputAxis * moveSpeed, moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Vector2 position = rigidbody.position;
        position += velocity * Time.fixedDeltaTime;
        Vector2 leftEdge = camera.ScreenToWorldPoint(Vector2.zero);
        Vector2 rightEdge = camera.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        position.x = Mathf.Clamp(position.x, leftEdge.x, rightEdge.x);
        rigidbody.MovePosition(position);
    }
}
