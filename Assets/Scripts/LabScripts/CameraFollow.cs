using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	///object that camera follows
	public Transform player;

	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	void Start()
	{

		offset = transform.position - player.transform.position;

	}

	void LateUpdate()
	{
		Vector3 desiredPosition = player.transform.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;
	}
}
