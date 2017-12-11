using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{

    public int coinPoints;
  
    private ScoreManager theScoreManager;

    private void Start()
    {
        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    
   void OnTriggerEnter2D(Collider2D other)
    {
            if (other.tag =="Player")
            {
            theScoreManager.AddPoints(coinPoints);
            Destroy(gameObject);
            }

       
        
    }
}
