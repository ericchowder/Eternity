using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour {

	public string text;
	private int counter = 0; //keep track of when players first unlock the desktop

	public Dialogue dialogue;

	public void TriggerObjective()
	{
		
		FindObjectOfType<ObjectiveTrigger>().ShowObjective(text);
	
		
	}
	public void TriggerHint()
	{
		FindObjectOfType<ObjectiveTrigger>().ShowHint(dialogue);
	}
}
