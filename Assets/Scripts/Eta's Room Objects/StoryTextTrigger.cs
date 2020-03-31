using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryTextTrigger : MonoBehaviour {

	public Dialogue story;

	public void TriggerStory()
	{
		FindObjectOfType<StoryManager>().StartDialogue(story);

	}
}
