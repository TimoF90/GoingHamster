using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;
    public Text highscoreText2;

    public static int scoreCount;
    public static int highscoreCount;

    private int score1;
    
    public Transform ScoreMarker;

    public GameObject HighscoreCanvas;
   
    public GameObject Player;
    public Rigidbody2D rb;
    private float speed;
    private float time;


    private Vector3 startPoint;
    private PauseMenu pauseMenu;
    

    private CoinScript theCoinScript;

    
    


    // Use this for initialization
    void Start () {
        
        scoreCount = 0;
        highscoreCount = PlayerPrefs.GetInt("aaa", 0);
        rb.GetComponent<Rigidbody2D>();
        startPoint = ScoreMarker.transform.position;
        Time.timeScale = 1.0f;

    }



    // Update is called once per frame
    void Update()
    {

        speed = rb.velocity.magnitude;
        time = Time.timeScale;

        if (Player.transform.position.x >= ScoreMarker.transform.position.x)
        {
            scoreCount = (int)Player.transform.position.x - (int)startPoint.x;
            //score1 = scoreCount;


        }

        scoreCount += score1;

        if (scoreCount > highscoreCount)
        {
            highscoreCount = scoreCount;
        }

        if (highscoreCount > PlayerPrefs.GetInt("aaa"))
        {
            PlayerPrefs.SetInt("aaa", highscoreCount);
        }


        if (speed == 0f)
        {


            HighscoreCanvas.SetActive(true);
        }


        


        scoreText.text = "Score: " + scoreCount;
        highscoreText.text = "Highscore: " + Mathf.Round(highscoreCount);
        highscoreText2.text = "" + Mathf.Round(scoreCount);

        if (pauseMenu.isPaused == true)
        {
            Time.timeScale = 0f;
        }

    }   

    public void AddPoints (int pointsToAdd)
    {
        score1 += pointsToAdd;
    }
   






}
