using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_minigame_movement : MonoBehaviour {

	public float panSpeed = 2f;

	// Use this for initialization
	void Start () {
		
	}

	void Update () {
		Vector3 pos = transform.position;
	
		if (Input.GetKey ("w")) {
			pos.z += panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("s")) {
			pos.z -= panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("d")) {
			pos.x += panSpeed * Time.deltaTime;
		}
		if (Input.GetKey ("a")) {
			pos.x -= panSpeed * Time.deltaTime;
		}

		transform.position = pos;

	}
}
