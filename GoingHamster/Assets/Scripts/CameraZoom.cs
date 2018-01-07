using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

    public Rigidbody2D rb;
    public float zoomSize =5;
   

    private float count, count1;
    private float time, speed;
    private PauseMenu pauseMenu;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        
        speed = rb.velocity.magnitude;
        time = Time.timeScale;


        if (speed > 5 && zoomSize >=5 && zoomSize <7)
        {
            count++;
            if (count==20) {
                zoomSize += 0.1f;
                count = 0;

            }
        }

        if (speed <10 && zoomSize >5)
        {
            count1++;
            if (count1 == 10)
            {
                zoomSize -= 0.05f;
                count1 = 0;
            }
        }

        if (pauseMenu.isPaused == true)
        {
            Time.timeScale = 0f;
        }

        GetComponent<Camera> ().orthographicSize = zoomSize;
    }
}
