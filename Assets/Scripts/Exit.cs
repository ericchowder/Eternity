using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour {
	public GameObject exit;
	private Scene current;
	void Start()
	{
		current = SceneManager.GetActiveScene();
	}

	// Update is called once per frame
	//players can move to another location only 
	//if the below requirements are fulfilled
	void Update() {
		//exit from her room to the elevator appears
		if (MemoryLense.lense.unlockedStatus1 == 1 && current.name == "EtaRoom2")
		{
			if (exit.name == "ExitBoundary")
			{
				exit.SetActive(true);
			}
			
		}

		//exit from the elevator to her room appears
		else if (MemoryLense.lense.obtainedStatus2 == 1 && (current.name == "Elevator2" || 
			current.name == "Elevator"))
		{
			exit.SetActive(true);

		}

		//exit from her room to the lab appears
		else if (MemoryLense.lense.obtainedStatus2 == 1 && (current.name == "EtaRoom2"))
		{
			exit.SetActive(true);

		}
	}
}
