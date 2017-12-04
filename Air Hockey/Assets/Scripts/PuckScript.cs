using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckScript : MonoBehaviour {

    Vector3 origPos;
    public bool gameStart = false;
    public int speed;
    int gameState;

// Use this for initialization
    void Start () {
        // Initialise New Game Round
        gameState = 0;
        // Get current puck position
        origPos = this.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (!gameStart) {
            this.transform.position = origPos;
        }

        if (Input.GetMouseButtonDown(0) && !gameStart) {
            gameStart = true;

            if (gameState == 0) {
                // Start Game Random
                Vector3 v = Quaternion.AngleAxis(Random.Range(20.0f, 340.0f), Vector3.forward) * Vector3.up;

                this.GetComponent<Rigidbody2D>().velocity = v * speed;
            }
            else if (gameState == 1){
                // If Player 2 Scores
                Vector3 v = Quaternion.AngleAxis(Random.Range(200.0f, 340.0f), Vector3.forward) * Vector3.up;

                this.GetComponent<Rigidbody2D>().velocity = v * speed;
            }
            else if (gameState == 2){
                // If Player 1 Scores
                Vector3 v = Quaternion.AngleAxis(Random.Range(20.0f, 160.0f), Vector3.forward) * Vector3.up;

                this.GetComponent<Rigidbody2D>().velocity = v * speed;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.CompareTag("P1Goal"))
        {
            // Player 2 Scored
            gameState = 1;
        }
        else if (trigger.CompareTag("P2Goal"))
        {
            // Player 1 Scored
            gameState = 2;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "P1Goal")
            print("You suck");

        if (gameStart && collision.collider.tag == "Border")
        {
            Vector2 tweak = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(0f, 0.2f));
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
