using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame()
	{
		
		//SceneManager.LoadScene(SceneManager.GetactiveScene().buildIndex + 1);
		SceneManager.LoadScene("Eta's Room");
		// or Scene name: SceneManager.LoadScene("Chapter01");
		// or Scene index: SceneManager.LoadScene(1);
	}

}
