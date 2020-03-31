using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour {

	public string text;
	private int counter = 0; //keep track of when players first unlock the desktop

	public Dialogue dialogue;

	public void TriggerObjective()
	{
		if (counter == 0)
		{
			FindObjectOfType<ObjectiveTrigger>().ShowHint(dialogue);
			FindObjectOfType<ObjectiveTrigger>().ShowObjective(text);
			counter = 1;
		}

		else
		{
			FindObjectOfType<ObjectiveTrigger>().ShowObjective(text);
		}

		return;
		
	}
}
