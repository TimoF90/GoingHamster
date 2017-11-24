using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollower : MonoBehaviour {

    private Vector2 velocity;

    public Transform player;
    public Transform farLeft;
    public Transform farRight;



    public float smoothTimeY;
    public float smoothTimeX;

    // Update is called once per frame
    void Update() {
        Vector3 newPosition = transform.position;

        
        newPosition.x = player.position.x;
        //   newPosition.x = Mathf.Clamp(newPosition.x, farLeft.position.x, farRight.position.x); //Kameraverfolgung start bei farLeft und endet bei farRight


        if (newPosition.x > 1) { 
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        transform.position = new Vector3(posX, posY, transform.position.z);

    }
     //   transform.position = newPosition;


	}
}
