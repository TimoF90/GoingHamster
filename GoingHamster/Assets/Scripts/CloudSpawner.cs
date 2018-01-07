using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour {

    public GameObject clouds;
    public GameObject hamster;
    public int counter_max = 60, spawnMin, spawnMax;
    public Vector2 spawnPosition;
    private int counter;

    void Start()
    {
       
          /*  int random = Random.Range(spawnMin, spawnMax);
            Vector2 temp = new Vector2(hamster.transform.position.x + 600, hamster.transform.position.y + Random.Range(5f, 10f));
            Instantiate(clouds, temp, Quaternion.identity);
            counter = 0; */
        
    }

    void FixedUpdate()
    {

        counter++;
        if (counter == counter_max)
        {
            int random = Random.Range(spawnMin, spawnMax);
            Vector2 temp1 = new Vector2(hamster.transform.position.x + 300, spawnPosition.y + Random.Range(5f, 10f));
            Instantiate(clouds, temp1, Quaternion.identity);
            counter = 0;
        }

    }
}
