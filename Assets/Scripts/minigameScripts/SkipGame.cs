using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipGame : MonoBehaviour {
    public string sceneToSkipTo;
    public string minigame;


    public void Skip1()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToSkipTo);
        SceneManager.UnloadSceneAsync(minigame);

        Destroy(GameObject.Find("MinigameAudio"));
        GameObject.FindGameObjectWithTag("Eta").GetComponent<BoxCollider2D>().enabled = true;

        MemoryLense.lense.unlockedStatus1 = 1;
        MemoryLense.lense.totalUnlocked = 1;
    }

    public void Skip2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToSkipTo);
        SceneManager.UnloadSceneAsync(minigame);

        Destroy(GameObject.Find("MinigameAudio"));
        GameObject.FindGameObjectWithTag("Eta").GetComponent<BoxCollider2D>().enabled = true;

        MemoryLense.lense.unlockedStatus2 = 1;
        MemoryLense.lense.totalUnlocked = 2;
    }

    public void Skip3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneToSkipTo);
        SceneManager.UnloadSceneAsync(minigame);

        Destroy(GameObject.Find("MinigameAudio"));
        GameObject.FindGameObjectWithTag("Eta").GetComponent<BoxCollider2D>().enabled = true;

        MemoryLense.lense.unlockedStatus3 = 1;
        MemoryLense.lense.totalUnlocked = 3;
    }
}
