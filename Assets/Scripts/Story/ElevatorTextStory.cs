using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElevatorTextStory : MonoBehaviour {
	//for format, location of the text
	public Text storyText;
	public Text pagenum;

	public GameObject page;
	public GameObject storyTextObject;

	public GameObject storyBackBtn;
	public GameObject storyContinueButton;
	public GameObject exitButton;

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
		pagenum.text = (currentSentence + 1) + "/" + sentenceCount;

		return;

	}

	//go forward in story
	public void DisplayNextSentence()
	{
		currentSentence++;
		this.sentence = sentences[currentSentence];
		pagenum.text = (currentSentence + 1) + "/" + sentenceCount;

		storyText.text = this.sentence;

		//when players are at the very end of the story, cant click anymore
		//to go forward
		if (currentSentence == sentenceCount - 1)
		{
			storyContinueButton.SetActive(false);
			exitButton.SetActive(true);

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
		pagenum.text = (currentSentence + 1) + "/" + sentenceCount;

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
			exitButton.SetActive(false);
		}


		return;
	}

	public void ResetCurrentSentence()
	{
		currentSentence = 0;
	}

}
