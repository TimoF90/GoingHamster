using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public string mainMenu;
    public string GameScene;

    public bool isPaused = false;
    public GameObject pauseMenuCanvas;

    


    



    // Update is called once per frame
    void Update()
    {

    }

    public void TogglePauseMenu()
    {
      
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;
        isPaused = true;
    }
        
        
          
        
    public void Restart()
    {
        SceneManager.LoadScene(GameScene);
        Time.timeScale = 1f;
    }
    
    public void Resume()
    {
        // isPaused = false;
        pauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void Quit()
    {
        SceneManager.LoadScene(mainMenu);

    }
}