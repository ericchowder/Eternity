using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoBacktoScene : MonoBehaviour {

    public string oldScene;
    public string newScene;

    public void BacktoRoom()
    {
        new WaitForEndOfFrame();
        SceneManager.LoadScene(newScene);
        SceneManager.UnloadSceneAsync(oldScene);
    }
}
