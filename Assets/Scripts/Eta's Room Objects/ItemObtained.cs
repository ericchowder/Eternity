using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemObtained : MonoBehaviour {

	public Dialogue dialogue;

	public GameObject item;

	public void TriggerItemObtained()
    {
		FindObjectOfType<ItemObtainedTrigger>().StartDialogue(dialogue, item);
	}

	public void TriggerLenseObtained()
	{
		if (PuzzlePiece.puzzlePieces.key == 1)
		{
			FindObjectOfType<ItemObtainedTrigger>().StartDialogue(dialogue, item);

		}

	}

	public void TriggerLense2Obtained()
	{
		if (PuzzlePiece.puzzlePieces.wire == 1)
		{
			FindObjectOfType<ItemObtainedTrigger>().StartDialogue(dialogue, item);

		}

	}


}
