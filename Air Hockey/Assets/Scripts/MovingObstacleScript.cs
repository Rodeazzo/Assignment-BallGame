using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacleScript : MonoBehaviour {

    public float posX;
    Vector3 pointA, pointB;

    // Use this for initialization
    void Start () {
		pointA = new Vector3(posX, -1, 1);
        pointB = new Vector3(posX, 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
        // transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
