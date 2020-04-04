using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundariesLab : MonoBehaviour {

	public GameObject background;
	public GameObject cameraFollow;

	void Update()
	{
		if (gameObject.transform.position.x > 0.2f || gameObject.transform.position.x < -7.5f)
		{
			cameraFollow.GetComponent<CameraFollow>().enabled = false;
		}

		else
		{
			cameraFollow.GetComponent<CameraFollow>().enabled = true;
		}

		transform.position = new Vector3(Mathf.Clamp(transform.position.x, 
			-14.85f, 7.15f),
			(Mathf.Clamp(transform.position.y, 
			-5.2f, 5.2f)));
	}
}
