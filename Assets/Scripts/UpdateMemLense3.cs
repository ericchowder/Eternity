using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMemLense3 : MonoBehaviour {

	//when players have obtained a mem. lense
	public void updateOStatus()
	{
		if (PuzzlePiece.puzzlePieces.chipcard == 1)
		{
			MemoryLense.lense.obtainedStatus3 = 1;
		}

	}

	//when mem. lense has been unlocked (game completed)
	public void updateUStatus()
	{
		MemoryLense.lense.totalUnlocked = 3;
		MemoryLense.lense.unlockedStatus3 = 1;
	}
}
