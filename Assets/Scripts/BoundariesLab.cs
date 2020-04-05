using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundariesLab : MonoBehaviour {

	public GameObject background;
	private Camera cameraFollow;

	void Update()
	{
		cameraFollow = GameObject.Find("Main Camera").GetComponent<Camera>();
		cameraFollow.transform.position = new Vector3(gameObject.transform.position.x, 0,
			gameObject.transform.position.z);


		transform.position = new Vector3(Mathf.Clamp(transform.position.x, 
			-14.85f, 7.15f),
			(Mathf.Clamp(transform.position.y, 
			-5.2f, 5.2f)));
	}
}
