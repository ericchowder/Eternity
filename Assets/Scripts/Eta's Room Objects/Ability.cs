using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ability : MonoBehaviour {
	public static Ability ability;

	//keep track of whether players have recovered Eta's ability
	//to time travel
	public int recovered = 0;

	public string oldScene;
	public string newScene;

	private Scene current;


	void Awake()
	{
	
		//if there is no current singleton, make this the singleton
		if (ability == null)
		{
			ability = this;
		}

		GameObject eta = GameObject.Find("Eta");
		DontDestroyOnLoad(eta);
		current = SceneManager.GetActiveScene();
	}

	void Start()
	{
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKey(KeyCode.Space) == true && recovered == 1)
		{
			new WaitForEndOfFrame();
		
			changeScene();
		
		}

	}

	public void changeScene()
	{
		SceneManager.LoadScene(newScene);

		SceneManager.UnloadSceneAsync(current.name);
	}
}
