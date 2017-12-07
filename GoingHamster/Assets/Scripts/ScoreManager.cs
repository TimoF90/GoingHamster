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
    private Vector3 startPoint;


	// Use this for initialization
	void Start () {
        
        scoreCount = 0f;
        highscoreCount = PlayerPrefs.GetFloat("aaa", 0);
        
        startPoint = ScoreMarker.transform.position;
        
    }
	
	// Update is called once per frame
	void Update () {


        

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

            

    

       
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highscoreText.text = "Highscore: " + Mathf.Round(highscoreCount);
        highscoreText2.text = "" + Mathf.Round(highscoreCount);

        



    }

   
}
