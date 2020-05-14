using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	///object that camera follows
	private Transform player;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	void Start()
	{
		player = GameObject.Find("Eta").transform;
		offset = transform.position - player.transform.position;

	}

	void LateUpdate()
	{
		if (transform.position.x > 0f)
		{
			transform.position = new Vector3(0f, 0f, -10f);
		}

		else if (transform.position.x < -7.0f)
		{
			transform.position = new Vector3(-7.2f, 0, -1.25f);
		}

		else
		{
			Vector3 desiredPosition = player.transform.position + offset;
			Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
			transform.position = smoothedPosition;
		}



	}
}
