using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StoryManager : MonoBehaviour {

	//for format, location of the text
	public Text storyText;

	public GameObject storyTextObject;
	public GameObject storyBackground;

	public GameObject storyBackBtn;
	public GameObject storyContinueButton;
	public GameObject storyExitButton;

	private int sentenceCount = 0;
	private int currentSentence = 0;

	//queue that holds the sentences that will display on the next page
	//when players want to continue through the story
	private string[] sentences; 

	private string sentence;

	public void StartDialogue(Dialogue dialogue)
	{

		sentences = dialogue.sentences;
		sentenceCount = sentences.Length;


		this.sentence = sentences[currentSentence];
		storyText.text = sentence;

		return;

	}

	//go forward in story
	public void DisplayNextSentence()
	{
		currentSentence++;
		this.sentence = sentences[currentSentence];
		
		storyText.text = this.sentence;

		//when players are at the very end of the story, cant click anymore
		//to go forward
		if (currentSentence == sentenceCount - 1)
		{
			storyContinueButton.SetActive(false);

			return;
		}

		//when players are past the beginning, the back button appears
		//allowing players to go back in the story
		else if (currentSentence >= 1)
		{
			storyBackBtn.SetActive(true);
		}

		return;
	}

	//go back in story
	public void GoBack()
	{
		currentSentence--;
		this.sentence = sentences[currentSentence];

		storyText.text = this.sentence;
		
		//when players are at the start of the story, cant click to go back
		if (currentSentence == 0)
		{
			storyBackBtn.SetActive(false);

			return;
		}

		//when players decide to go back on the last page of the story
		//button appears allowing playesr to go forward in the story again
		else if (currentSentence < sentenceCount - 1)
		{
			storyContinueButton.SetActive(true);
		}

		
		return;
	}

	public void ResetCurrentSentence()
	{
		currentSentence = 0;
	}

	void EndDialogue()
	{
		//make textbox and dialogue disappear when finished
		storyExitButton.SetActive(false);
		storyBackBtn.SetActive(false);
		storyContinueButton.SetActive(false);

		storyTextObject.SetActive(false);
		storyBackground.SetActive(false);

	}
}
