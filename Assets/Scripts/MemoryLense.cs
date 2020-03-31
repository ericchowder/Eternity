using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryLense : MonoBehaviour {

	public static MemoryLense lense;
	//keep track of whether lense 1 has been obtained or not
	public int obtainedStatus1;
	public int unlockedStatus1;

	//keep track of whether lense 2 has been obtained or not
	public int obtainedStatus2;
	public int unlockedStatus2;

	//keep track of whether lense 3 has been obtained or not
	public int obtainedStatus3;
	public int unlockedStatus3;

	//keep track of whether lense 4 has been obtained or not
	public int obtainedStatus4;
	public int unlockedStatus4;

	public int totalUnlocked;



	void Awake()
	{
		//if there is no current singleton, make this the singleton
		if (lense == null)
		{
			DontDestroyOnLoad(gameObject);
			lense = this;
		}

		//if one already exists, make sure this does not become the current singleton
		//only want one to exist
		else if (lense != this)
		{
			Destroy(gameObject);
		}

	}
}
