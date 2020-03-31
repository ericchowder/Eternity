using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundariesElevator : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3f, 3f),
			(Mathf.Clamp(transform.position.y, -4f, 4f)));
	}
}
