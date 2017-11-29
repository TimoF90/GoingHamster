using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{



    // Update is called once per frame
    void Update()
    {

    }
        void OnCollisionEnter2D(Collision2D coll)
        {
            if (coll.gameObject.tag.Equals ("Player"))
            {
                ScoreManager.scoreCount += 10;
                Destroy(gameObject);
            }


        
    }
}
