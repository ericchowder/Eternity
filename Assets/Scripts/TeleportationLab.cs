using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeleportationLab : MonoBehaviour {

	public string oldScene;
	public string newScene;


	void Awake()
	{
		GameObject eta = GameObject.Find("Eta");

		DontDestroyOnLoad(eta);
	
	}

	void Start()
	{
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKey(KeyCode.Space) == true)
		{

			changeScene();

		}

	}

	public void changeScene()
	{
		new WaitForEndOfFrame();
		SceneManager.LoadScene(newScene);
		SceneManager.UnloadSceneAsync(oldScene);
	}
}
