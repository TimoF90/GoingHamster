using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour {

    public float movementSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPosition = transform.position;
        transform.position = new Vector2(currentPosition.x - movementSpeed, currentPosition.y);
    }
}
