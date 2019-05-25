using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //These are the desinger variables
    public float speed = 10;
    public float jumpSpeed = 10;
    public Rigidbody2D physicsBody;
    public string horizontalAxis = "Horizontal";

    public SpriteRenderer playerSprite;
    public Animator playerAnimator;
    public Collider2D playerCollider;
    public Lives livesObject;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        // Get axis input from Unity
        float leftRight = Input.GetAxis(horizontalAxis);

        // Create direction vector from axis input
        Vector2 direction = new Vector2(leftRight, 0);

        // Make direction vector length 1
        direction = direction.normalized;

        // Calculate velocity
        Vector2 velocity = direction * speed;
        velocity.y = physicsBody.velocity.y;

        // Give the velocity to the rigidbody
        physicsBody.velocity = velocity;

        // Tell the animator our speed
        playerAnimator.SetFloat("walk", Mathf.Abs(velocity.x));

        // Flip our sprite if we're moving backward
        if (velocity.x < 0)
        {
            playerSprite.flipX = true;
        }
        else
        {
            playerSprite.flipX = false;
        }

        
        }

    public void Kill()
    {
        // Take away a life and save that change
        livesObject.LoseLife();
        livesObject.SaveLives();

        // Check if it's game over
        bool gameOver = livesObject.IsGameOver();

        if (gameOver == true)
        {
            // If it IS game over....
            // Load the game over scene
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            // If it is NOT game over....
            // Reset the current level to restart from the beginning.

            // First, ask unity what the current level is
            Scene currentLevel = SceneManager.GetActiveScene();

            // Second, tell unity to load the current again
            // by passing the build index of our level
            SceneManager.LoadScene(currentLevel.buildIndex);

        }

    }




    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }

    }
} 
    

      