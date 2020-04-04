using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundariesLab : MonoBehaviour {

	public GameObject background;
	public GameObject cameraFollow;

	void Update()
	{
		if (transform.position.x > 0f || transform.position.x < -7f)
		{
			cameraFollow.GetComponent<CameraFollow>().enabled = false;
		}
		cameraFollow.GetComponent<CameraFollow>().enabled = true;

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, 
			-16.10f, 8.9f),
			(Mathf.Clamp(transform.position.y, 
			-5.2f, 5.2f)));
	}
}
