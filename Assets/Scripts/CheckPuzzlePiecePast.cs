using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CheckPuzzlePiecePast : MonoBehaviour {
	public Dialogue dialogue;
	public void CheckStatus_Past()
	{
		if (PuzzlePiece.puzzlePieces.key == 1)
		{
			EventSystem.current.currentSelectedGameObject.GetComponent<DialogueTrigger>().dialogue = dialogue;
		}
	}

	public void CheckWirePast()
	{
		if (PuzzlePiece.puzzlePieces.wire == 1)
		{
			EventSystem.current.currentSelectedGameObject.GetComponent<DialogueTrigger>().dialogue = dialogue;
		}
	}
}
