using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.RotateAround (new Vector3 (3.5f, -2.5f, 0f), new Vector3 (0f, 0f, 1f), 90f * Time.deltaTime);
	}
}
