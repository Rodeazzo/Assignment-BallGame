using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePos = (Input.mousePosition.y / Screen.height * 10) - 5;

        Vector3 newPaddlePos = new Vector3(this.transform.position.x, mousePos, 
                                           this.transform.position.z);

        newPaddlePos.y = Mathf.Clamp(mousePos, -4.12f, 4.12f);

        this.transform.position = newPaddlePos;
	}
}
