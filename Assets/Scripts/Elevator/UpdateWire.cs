using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateWire : MonoBehaviour {

	//update variable so the button to click on the wire can appear
	public void Activate()
	{
		Wire.wire.activate = 1;
	}

}
