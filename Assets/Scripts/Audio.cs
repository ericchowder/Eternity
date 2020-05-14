using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
	public static Audio gameAudio;

	void Awake()
	{
		//if there is no current singleton, make this the singleton
		if (gameAudio == null)
		{
			DontDestroyOnLoad(gameObject);
			gameAudio = this;
		}

		//if one already exists, make sure this does not become the current singleton
		//only want one to exist
		else if (gameAudio != this)
		{
			Destroy(gameObject);
		}

	}
}
