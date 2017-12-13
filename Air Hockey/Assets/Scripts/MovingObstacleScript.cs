using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacleScript : MonoBehaviour {

    public float posX;
    public int obstacle;
    Vector3 pointA, pointB;

    // Use this for initialization
    void Start () {
        if(obstacle == 0)
        {
            pointA = new Vector3(posX, -3, 2);
            pointB = new Vector3(posX, 3, 2);
        }
		if(obstacle == 1)
        {
            pointA = new Vector3(posX, 3, 2);
            pointB = new Vector3(posX, -3, 2);
        }
    }
	
	// Update is called once per frame
	void Update () {
        // transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
