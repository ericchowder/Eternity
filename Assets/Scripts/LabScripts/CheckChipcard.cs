using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckChipcard : MonoBehaviour {
	public Dialogue dialogue;

	public GameObject login;
	public GameObject input;
	public GameObject background;



	void Start()
	{
		if (PuzzlePiece.puzzlePieces.chipcard == 1)
		{
			gameObject.GetComponent<DialogueTrigger>().dialogue = dialogue;
		}
	}

	public void Check()
	{
		if (PuzzlePiece.puzzlePieces.chipcard == 1)
		{
			gameObject.GetComponent<DialogueTrigger>().dialogue = dialogue;
			login.SetActive(true);
			input.SetActive(true);
			background.SetActive(true);
		}
	}
}
