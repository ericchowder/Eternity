using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateWireButton : MonoBehaviour {
	public GameObject button;

	// Use this for initialization
	void Start () {
		if (Wire.wire.activate == 1)
		{
			button.SetActive(true);
		}
	}
	
}
