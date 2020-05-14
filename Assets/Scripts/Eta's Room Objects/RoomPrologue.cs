using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomPrologue : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;

	public GameObject textboxObject;
	public GameObject dialogueObject;
	public GameObject nameObject;

	public GameObject headshot;

	public GameObject continueBtn;

	private Queue<string> sentences;

	public Dialogue dialogue;

	public GameObject objective;

	// Use this for initialization
	void Start()
	{
		sentences = new Queue<string>();

	}

	public void StartDialogue()
	{
		//make textbox and dialogue appear onto screen
		continueBtn.SetActive(true);
		nameObject.SetActive(true);
		dialogueObject.SetActive(true);
		textboxObject.SetActive(true);
		headshot.SetActive(true);

		nameText.text = dialogue.name;

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
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines(); //immediately stops letters from appearing one by one
		StartCoroutine(TypeSentence(sentence)); //trigger letters to start appearing one by one
		return;
	}

	IEnumerator TypeSentence(string sentence)
	{
		//make letters in dialogue appear one by one
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		{
			//make textbox and dialogue disappear when finished
			continueBtn.SetActive(false);
			textboxObject.SetActive(false);
			nameObject.SetActive(false);
			dialogueObject.SetActive(false);
			headshot.SetActive(false);

			objective.GetComponent<PrologueObjective>().ShowObjective();

			gameObject.GetComponent<ShowTrigger>().ShowObjs();

		}

	}
}
