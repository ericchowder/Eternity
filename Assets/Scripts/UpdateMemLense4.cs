using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMemLense4 : MonoBehaviour {

	//when players have obtained a mem. lense
	public void updateOStatus()
	{
		if (PuzzlePiece.puzzlePieces.piece4 == 1)
		{

			MemoryLense.lense.obtainedStatus4 = 1;
		}

	}

	//when mem. lense has been unlocked (game completed)
	public void updateUStatus()
	{
		MemoryLense.lense.totalUnlocked = 4;

		MemoryLense.lense.unlockedStatus4 = 1;
	}
}
