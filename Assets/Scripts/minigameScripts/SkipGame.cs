using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipGame : MonoBehaviour {
    public string sceneToSkipTo;
    public string minigame;


    public void Skip()
    {
        SceneManager.LoadScene(sceneToSkipTo);
        SceneManager.UnloadSceneAsync(minigame);

        Destroy(GameObject.Find("MinigameAudio"));
    }
}
