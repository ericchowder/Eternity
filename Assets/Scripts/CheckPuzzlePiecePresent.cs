using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class CheckPuzzlePiecePresent : MonoBehaviour {

	//dialogue to be displayed when item has been obtained and is used on
	//one of the objects
	public Dialogue dialogue;

	//void Start()
	//{
	//Check();
	//}

	//can be called when item has been obtained
	public void UpdateKeyStatus()
	{
		PuzzlePiece.puzzlePieces.key = 1;
	}

	void Start()
	{
		CheckStatus_Present();
	}

	public void CheckStatus_Present()
	{
		if (PuzzlePiece.puzzlePieces.key == 1)
		{
			gameObject.GetComponent<DialogueTrigger>().dialogue = dialogue;
			
		}
	}

}
