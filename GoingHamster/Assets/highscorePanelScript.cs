using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class highscorePanelScript : MonoBehaviour {

    public GameObject HighscoreCanvas;
    public float yPosition;
    public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (rb.transform.position.y < yPosition && rb.transform.position.x > 4)
        {
            HighscoreCanvas.SetActive(true);
        }
    }
}
