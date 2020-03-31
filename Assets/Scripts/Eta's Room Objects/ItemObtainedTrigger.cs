using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ItemObtainedTrigger : MonoBehaviour {

	public Text obtainedText;

	public GameObject obtainedTextObj;
	public GameObject textbox;

	public GameObject exitBtn;
	public GameObject continueBtn;

	private Queue<string> sentences;
	private string objTag;

	void Start()
	{
		sentences = new Queue<string>();
	}

	public void StartDialogue(Dialogue dialogue, GameObject item)
	{
		//make textbox and dialogue appear onto screen
		continueBtn.SetActive(true);

		obtainedTextObj.SetActive(true);
		textbox.SetActive(true);

		item.SetActive(true);

		objTag = EventSystem.current.currentSelectedGameObject.tag;

		sentences.Clear();

		//iterates through queue that is holding the dialogue sentences(?)
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
		return;

	}

	public void DisplayNextSentence()
	{
		string sentenceDisplayed = sentences.Dequeue();
		
		if (objTag == "Tank")
		{
			
			
			StopAllCoroutines(); //immediately stops letters from appearing one by one
			StartCoroutine(TypeSentence(sentenceDisplayed)); //trigger letters to start appearing one by one
			if (sentences.Count == 0)
			{
				exitBtn.SetActive(true);
				continueBtn.SetActive(false);
				return;
			}
			
			return;
			
		}

		else
		{
			exitBtn.SetActive(true);
			continueBtn.SetActive(false);

			obtainedText.text = sentenceDisplayed;
			return;
		}
		
	}

	IEnumerator TypeSentence(string sentence)
	{
		//make letters in dialogue appear one by one
		obtainedText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			obtainedText.text += letter;
			yield return null;
		}
	}


}
