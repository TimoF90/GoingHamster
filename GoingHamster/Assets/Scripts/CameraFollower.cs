using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

    private Vector2 velocity;

    public float smoothTimeY;
    public float smoothTimeX;

    public GameObject Hamster;


    void Start () {

        Hamster = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        float posX = Mathf.SmoothDamp(transform.position.x, Hamster.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, Hamster.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector2(posX, posY);

        //, transform.position.z
    }
}
