using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit_detection : MonoBehaviour {

	public GameObject etaObject;
	Vector2 playerPos;

	private void Awake() {
		playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
	}

	private void OnTriggerEnter2D(Collider2D collider) {
		etaObject.transform.position = new Vector2 (-0.2f, -1.2f);
		//playerPos = new Vector2 (-0.2f, -1.2f);
		//playerPos.y = -1.2f;

		//Debug.Log ("detected");
		Debug.Log ("player position is" + playerPos);
	}
}
