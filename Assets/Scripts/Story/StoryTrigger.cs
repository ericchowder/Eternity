using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTrigger : MonoBehaviour {

	public Dialogue dialogue;


	public void TriggerStory()
	{
		FindObjectOfType<ElevatorTextStory>().StartDialogue(dialogue);
	}

	void Start()
    {
		TriggerStory();
    }
}
