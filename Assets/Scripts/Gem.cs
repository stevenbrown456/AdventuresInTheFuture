using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{

    //  lets us add to the score
    public Score scoreObject;

    // Variable to hold the coin's point value

    public int coinValue;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    // Unity calls this function when our coin touches any other object
    // coin should disappear when player colides
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the thing we touched was the Player
        PlayerMovement playerScript = collision.collider.GetComponent<PlayerMovement>();


        if (playerScript)
        {


            // Adds to the score
            scoreObject.AddScore(coinValue);

            // Destroy the gameObject that this script is attached to

            Destroy(gameObject);
        }
    }



}

