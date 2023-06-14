using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    public Animator animator;
    private new Camera camera;
    private new Rigidbody2D rigidbody;
    public float moveSpeed = 8f;
    private float inputAxis;
    private Vector2 velocity;

    private void Awake() //call this function when script is initialized
    {
        rigidbody = GetComponent<Rigidbody2D>();
        camera = Camera.main;
    }

    private void Update() //called every single frame the game is running
    {
        HorizontalMovement();

        animator.SetFloat("Speed", Mathf.Abs(velocity.x)); //to set animation with speed

         if(velocity.x < 0f){ //for rotation of object face in both direction
        transform.eulerAngles = Vector3.zero;
        } 
         else if(velocity.x > 0f){
        transform.eulerAngles = new Vector3(0f, 180f, 0f);

       }
    }

    private void HorizontalMovement()
    {
        inputAxis = Input.GetAxis("Horizontal");
        velocity.x = Mathf.MoveTowards(velocity.x, inputAxis*moveSpeed, moveSpeed*Time.deltaTime); //for velocity of object
    }

    private void FixedUpdate() //run for only fixed interval
    {
        Vector2 position = rigidbody.position;
        position += velocity * Time.fixedDeltaTime;
        Vector2 leftEdge = camera.ScreenToWorldPoint(Vector2.zero);
        Vector2 rightEdge = camera.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        position.x = Mathf.Clamp(position.x, leftEdge.x, rightEdge.x);
        rigidbody.MovePosition(position); //to move to a specific position
    }
}
