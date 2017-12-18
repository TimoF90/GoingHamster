using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDestroyer : MonoBehaviour {


    
    public float lifeTime = 6f;
    


    // Use this for initialization
    void Start () {
        Destroy(gameObject, lifeTime);
    }

    void FixedUpdate()
    {
      /*  Vector2 currentPosition = transform.position;
        transform.position = new Vector2(currentPosition.x - movementSpeed, currentPosition.y);
           
    */
    }
}
