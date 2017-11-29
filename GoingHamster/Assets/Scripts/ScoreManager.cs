using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text highscoreText;

    public static float scoreCount;
    public static float highscoreCount;

    public float pointPerSecond;

    public bool scoreIncreasing;
    public Transform ScoreMarker;

    HamsterScript TheHamsterScript;
    public GameObject Player;


	// Use this for initialization
	void Start () {
        TheHamsterScript = FindObjectOfType<HamsterScript>();
        scoreCount = 0f;
	}
	
	// Update is called once per frame
	void Update () {

        //TheHamsterScript.transform.position 

        if (Player.transform.position.x >= ScoreMarker.transform.position.x)
        {

            //scoreCount += pointPerSecond * Time.deltaTime;
            scoreCount += ((ScoreMarker.transform.position.x - ScoreMarker.transform.position.x) + Player.transform.position.x) /100f;

        }

        if(scoreCount > highscoreCount)
        {
            highscoreCount = scoreCount;
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highscoreText.text = "Highscore: " + Mathf.Round(highscoreCount);
	}
}
