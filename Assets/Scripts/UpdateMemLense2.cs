using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMemLense2 : MonoBehaviour
{

	//when players have obtained a mem. lense
	public void updateOStatus()
	{
		if (PuzzlePiece.puzzlePieces.wire == 1)
		{
			MemoryLense.lense.obtainedStatus2 = 1;
		}

	}

	//when mem. lense has been unlocked (game completed)
	public void updateUStatus()
	{
		MemoryLense.lense.totalUnlocked = 2;
		MemoryLense.lense.unlockedStatus2 = 1;
	}
}
