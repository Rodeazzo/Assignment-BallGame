using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckScript : MonoBehaviour {

    RedPaddleScript redPaddle;
    BluePaddleScript bluePaddle;
    Vector3 origPos;
    public bool gameStart = false;

// Use this for initialization
    void Start () {
        origPos = this.transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        if (!gameStart) {
            this.transform.position = origPos;
        }

        if (Input.GetMouseButtonDown(0) && !gameStart) {
            gameStart = true;
            Vector3 v = Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), Vector3.forward) * Vector3.up;
            this.GetComponent<Rigidbody2D>().velocity = v * 12f;
        }

	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colName = collision.collider.name;

        if (gameStart && collision.collider.tag != "Border")
        {
            Vector2 tweak = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(0f, 0.2f));
            this.GetComponent<Rigidbody2D>().velocity += tweak;
        }
    }
}
