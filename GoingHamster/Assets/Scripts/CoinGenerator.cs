
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    /* public ObjectPooler coinPool;

     public float distanceCoins;

     public void SpawnCoins(Vector3 startPosition)
     {
         GameObject coin1 = coinPool.GetPooledObject();
         coin1.transform.position = startPosition;
         coin1.SetActive(true);

         GameObject coin2 = coinPool.GetPooledObject();
         coin2.transform.position = new Vector3(startPosition.x - distanceCoins, startPosition.y, startPosition.z);
         coin2.SetActive(true);

         GameObject coin3 = coinPool.GetPooledObject();
         coin3.transform.position = new Vector3(startPosition.x + distanceCoins, startPosition.y, startPosition.z);
         coin3.SetActive(true);
     }

     private void Update()
     {

     }*/

    //Array of objects to spawn (note I've removed the private goods variable)
    //public GameObject[] theGoodies;
    public GameObject coins;
    public Rigidbody2D rb;

    private Vector2 pos;
    private float speed;
    private float time;


    //Time it takes to spawn theGoodies
    [Space(3)]
    public float waitingForNextSpawn = 10;
    public float theCountdown = 10;

    // the range of X
    [Header("X Spawn Range")]
    public float xMin;
    public float xMax;

    // the range of y
    [Header("Y Spawn Range")]
    public float yMin;
    public float yMax;


    void Start()
    {
    }

    public void Update()
    {
        // timer to spawn the next goodie Object
        theCountdown -= Time.deltaTime;
        speed = rb.velocity.magnitude;
        time = Time.timeScale;

        if(speed > 3f)
        {
            if (theCountdown <= 0)
            {
                SpawnGoodies();
                theCountdown = waitingForNextSpawn;
            }
        }

        
    }


    void SpawnGoodies()
    {
        // Defines the min and max ranges for x and y
         Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));

        // Choose a new goods to spawn from the array (note I specifically call it a 'prefab' to avoid confusing myself!)
       // GameObject goodsPrefab = theGoodies[Random.Range(0, theGoodies.Length)];

        // Creates the random object at the random 2D position.
        Instantiate(coins, pos, transform.rotation);

        // If I wanted to get the result of instantiate and fiddle with it, I might do this instead:
        //GameObject newGoods = (GameObject)Instantiate(goodsPrefab, pos)
        //newgoods.something = somethingelse;
    }

   
}
