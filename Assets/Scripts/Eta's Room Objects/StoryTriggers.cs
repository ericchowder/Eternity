using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

//functions to display/open the story for players to read
public class StoryTriggers : MonoBehaviour {
	public UserConfirmation userConfirm;
	public StoryTemplate template;
	private Queue<string> sentences;
	
	public void UserConfirm()
	{
		userConfirm.yesButton.SetActive(true);
		userConfirm.noButton.SetActive(true);
		userConfirm.questionText.SetActive(true);
		userConfirm.textbox.SetActive(true);
	}
	
}
