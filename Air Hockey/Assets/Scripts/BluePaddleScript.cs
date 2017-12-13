using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.y += 20.0f * Time.deltaTime;
            position.y = Mathf.Clamp(position.y, -4.12f, 4.12f);
            this.transform.position = position;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.y-= 20.0f * Time.deltaTime;
            position.y = Mathf.Clamp(position.y, -4.12f, 4.12f);
            this.transform.position = position;
        }
    }
}
