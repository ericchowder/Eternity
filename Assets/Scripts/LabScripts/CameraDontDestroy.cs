using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDontDestroy : MonoBehaviour {
	public static CameraDontDestroy cameraFollow;
	void Awake()
	{
		//if there is no current singleton, make this the singleton
		if (cameraFollow == null)
		{
			DontDestroyOnLoad(gameObject);
			cameraFollow = this;
		}

		//if one already exists, make sure this does not become the current singleton
		//only want one to exist
		else if (cameraFollow != this)
		{
			Destroy(gameObject);
		}

	}
}
