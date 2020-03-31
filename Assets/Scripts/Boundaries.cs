using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour {
	private Vector2 screenBoundaries;
	private float objectW;
	private float objectH;

	// Use this for initialization
	void Start () {
		screenBoundaries = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
		objectW = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
		objectH = transform.GetComponent<SpriteRenderer>().bounds.extents.y;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 viewPos = transform.position;
		viewPos.x = Mathf.Clamp(viewPos.x, screenBoundaries.x * -1 + objectW, screenBoundaries.x - objectW);
		viewPos.y = Mathf.Clamp(viewPos.y, screenBoundaries.y * -1 + objectH, screenBoundaries.y - objectH);
		transform.position = viewPos;
	}
}
