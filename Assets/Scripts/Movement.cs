using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : MonoBehaviour {

	//public CharacterController controller;
	public Animator animator;

	int idle = 0;
	int right = 1;
	int left = -1;

	public float moveSpeed = 5f;

	// Update is called once per frame
	void Update () {
		float movement = Input.GetAxis("Horizontal");

		if (movement < 0) {
			animator.SetBool("idle", false);
			animator.SetBool("walk_left", true);
			animator.SetBool("walk_right", false);
			
		}
		else if (movement > 0) {
			animator.SetBool("idle", false);
			animator.SetBool("walk_left", false);
			animator.SetBool("walk_right", true);
			
		}
		else if (movement == 0) {
			animator.SetBool("idle", true);
			animator.SetBool("walk_left", false);
			animator.SetBool("walk_right", false);
		}
		

		transform.Translate(Vector3.right * movement * Time.deltaTime * moveSpeed);
		
	}

}
