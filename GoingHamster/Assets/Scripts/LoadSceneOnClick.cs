using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

    public string GameScene;

    public void LoadScene()
    {
        SceneManager.LoadScene(GameScene);
    }
}
