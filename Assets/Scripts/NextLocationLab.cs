using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLocationLab : MonoBehaviour {

	//button to appear to go to the next location
	public GameObject exit;
	public GameObject pressUp;

	public string oldScene;
	public string newScene;

	private Scene current;

	void Awake()
	{

		current = SceneManager.GetActiveScene();
	}

	// Use this for initialization
	void Start()
	{
		Time.timeScale = 1;
	}

	// Update is called once per frame
	void Update()
	{
		if ((Input.GetKey(KeyCode.W) == true || Input.GetKey(KeyCode.UpArrow) == true)
			&& exit.activeSelf == true)
		{
			new WaitForEndOfFrame();
			Destroy(GameObject.Find("Eta"));
			changeScene();

		}
	}

	//when player comes within the range of the
	//button to go the next location
	void OnTriggerEnter2D(Collider2D other)
	{
		exit.SetActive(true);
		pressUp.SetActive(true);

	}

	public void changeScene()
	{
		SceneManager.LoadScene(newScene);

		SceneManager.UnloadSceneAsync(current.name);
	}

	//when players leave the range
	void OnTriggerExit2D(Collider2D other)
	{
		exit.SetActive(false);
		pressUp.SetActive(false);
	}
}
