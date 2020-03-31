using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	//public CharacterController controller;
	public Animator animator;

	bool walk_left = false;
	bool walk_right = false;
	bool idle = true;

	public float moveSpeed = 5f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow) == false && Input.GetKey(KeyCode.RightArrow) == false) {
			animator.SetBool("idle", true);
			animator.SetBool("walk_left", false);
			animator.SetBool("walk_right", false);
		}
		else if (Input.GetKey(KeyCode.LeftArrow) == true) {
			animator.SetBool("idle", false);
			animator.SetBool("walk_left", true);
			animator.SetBool("walk_right", false);
		}
		else if (Input.GetKey(KeyCode.RightArrow) == true) {
			animator.SetBool("idle", false);
			animator.SetBool("walk_left", false);
			animator.SetBool("walk_right", true);
		}
	}

	void FixedUpdate() {
		Vector3 movement = new Vector3 (Input.GetAxis ("Horizontal"), 0f, 0f);
		transform.position += movement * Time.deltaTime * moveSpeed;
	}
}
