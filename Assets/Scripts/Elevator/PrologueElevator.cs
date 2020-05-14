using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrologueElevator : MonoBehaviour {
	public Text nameText;
	public Text dialogueText;

	public GameObject textboxObject;
	public GameObject dialogueObject;
	public GameObject nameObject;

	public GameObject headshot;

	public GameObject exitButton;

	// Use this for initialization
	void Start () {
		Dialogue dialogue = gameObject.GetComponent<DialogueTrigger>().dialogue;

		exitButton.SetActive(true);
		nameObject.SetActive(true);
		dialogueObject.SetActive(true);
		textboxObject.SetActive(true);
		headshot.SetActive(true);

		nameText.text = dialogue.name;
		dialogueText.text = dialogue.sentences[0];
	}
	
}
