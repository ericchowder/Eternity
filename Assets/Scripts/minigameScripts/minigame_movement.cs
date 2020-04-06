using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class minigame_movement : MonoBehaviour {

	//Vector2 playerSize;

	public float moveSpeed = 5f;
	public GameObject etaObject;
	public GameObject endMenuUI;
	private bool myDelay = false;
	//public float panSpeed = 20f;
	//public Rigidbody2D rb;


	Vector2 pos;
	string prevChar;
	float dPos;
	float dPos2;
	float dPos3;

	// Use this for initialization
	void Start () {
		//playerSize = gameObject.GetComponent<SpriteRenderer> ().bounds.extents;
	}
	/*
	// Update is called once per frame
	void Update () {
		Movement.x = Input.GetAxisRaw ("Horizontal");
		Movement.y = Input.GetAxisRaw ("Vertical");
	}

	void FixedUpdate() {
		rb.MovePosition (rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
	}
	*/


	void Update () {
		if (myDelay == true) {
			StartCoroutine (DelayCoroutine ());
		}

		pos = transform.position;

		dPos3 = dPos2;
		dPos2 = dPos;
		dPos = moveSpeed * Time.deltaTime; 
		
		if (Input.GetKey ("w")) {
			//pos.y += dPos + dPos2 * 0.5f + dPos3 * 0.25f;
			pos.y += dPos;
			prevChar = "w";
		}
		if (Input.GetKey ("s")) {
			pos.y -= dPos;
			prevChar = "s";
		}
		if (Input.GetKey ("d")) {
			pos.x += dPos;
			prevChar = "d";
		}
		if (Input.GetKey ("a")) {
			pos.x -= dPos;
			prevChar = "a";
		}
		if (((Input.GetKey ("w")) || Input.GetKey ("s") || Input.GetKey ("d") || Input.GetKey ("a")) == false) {
			if (prevChar == "w") {
				pos.y += dPos * 0.5f;
			}
			if (prevChar == "s") {
				pos.y -= dPos * 0.5f;
			}
			if (prevChar == "d") {
				pos.x += dPos * 0.5f;
			}
			if (prevChar == "a") {
				pos.x -= dPos * 0.5f;
			}
		}
			
		transform.position = pos;
		//Debug.Log ("Current position is:" + pos);
		//Debug.Log ("w is " + (Input.GetKey ("w")));
		//Debug.Log ("total is " + (Input.GetKey ("w") && Input.GetKey ("s") && Input.GetKey ("d") && Input.GetKey ("a")));
	}

	private void OnTriggerEnter2D(Collider2D collided) {
		if (collided.gameObject.tag == "Finish") {
			endMenuUI.SetActive (true);
			Time.timeScale = 0f;
			//Debug.Log ("touched");
		} else {
			etaObject.transform.position = new Vector2 (5.75f, 3f);
			prevChar = null;
			myDelay = true;
		}
	}

	IEnumerator DelayCoroutine() {
		yield return new WaitForSeconds (5);
		myDelay = false;
	}

	public void QuitGame() {
		Debug.Log ("Load Exit Scene here");
		Time.timeScale = 1f;
		SceneManager.LoadScene ("RoomStory");
		SceneManager.UnloadSceneAsync("minigame");
//		GameObject.FindGameObjectWithTag("Eta").GetComponent<BoxCollider2D>().enabled = true;
		Destroy(GameObject.Find("MinigameAudio"));
		//Application.Quit();
	}

	public void Restart() {
		Time.timeScale = 1f;
		SceneManager.LoadScene ("minigame");
	}


}
