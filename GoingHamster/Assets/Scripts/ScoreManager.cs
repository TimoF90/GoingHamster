using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;
    public Text highscoreText2;

    public static float scoreCount;
    public static float highscoreCount;

       
    public bool scoreIncreasing;
    public Transform ScoreMarker;

    public GameObject HighscoreCanvas;
   
    public GameObject Player;
    public Rigidbody2D rb;
    private float speed;


    private Vector3 startPoint;
    private bool stop = false;

    public Transform player;
    private float counter;


    // Use this for initialization
    void Start () {
        
        scoreCount = 0f;
        highscoreCount = PlayerPrefs.GetFloat("aaa", 0);
        rb.GetComponent<Rigidbody2D>();
        startPoint = ScoreMarker.transform.position;
        
    }
	
	// Update is called once per frame
	void Update () {

      /*  if (player.transform.position.y < -3)
        {

            float counter = +1;
            if (player.transform.position.y < -3 && counter < 10)
            {
                highscoreText.text = "Highscore: " + Mathf.Round(highscoreCount) + "NEUER HIGHSCORE!!!";
            }


        }*/




        if (Player.transform.position.x >= ScoreMarker.transform.position.x)
        {
            
            
          scoreCount = Player.transform.position.x - startPoint.x;
          
            
           

        }

        if (scoreCount > highscoreCount)
        {
            highscoreCount = scoreCount;

        }

        if(highscoreCount > PlayerPrefs.GetFloat("aaa"))
        {

            PlayerPrefs.SetFloat("aaa", highscoreCount);
        }

        speed = rb.velocity.magnitude;
        Time.timeScale = 1.0f;

        if (speed == 0f)
        {

            HighscoreCanvas.SetActive(true);
        }


            

    

       
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highscoreText.text = "Highscore: " + Mathf.Round(highscoreCount);
        highscoreText2.text = "" + Mathf.Round(scoreCount);

        
    }

    

   
}
