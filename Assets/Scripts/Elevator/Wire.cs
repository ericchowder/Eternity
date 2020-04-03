using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour {
	public static Wire wire;
	//keep track if the touchpad in the past has been clicked on 
	//if it has, then the button to click on the wire will appear
	public int activate;

	void Awake()
	{
		//if there is no current singleton, make this the singleton
		if (wire == null)
		{
			DontDestroyOnLoad(gameObject);
			wire = this;
		}

		//if one already exists, make sure this does not become the current singleton
		//only want one to exist
		else if (wire != this)
		{
			Destroy(gameObject);
		}

	}

	
}
