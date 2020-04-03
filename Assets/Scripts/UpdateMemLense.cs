using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//solely for updating the variables, if players have obtained the
//memory lense and if they have unlocked it yet(beat the minigame)
public class UpdateMemLense : MonoBehaviour {

	///when players have obtained a mem. lense
	public void updateOStatus()
	{
		if (PuzzlePiece.puzzlePieces.key == 1)
		{
			MemoryLense.lense.obtainedStatus1 = 1;
		}

	}

	//when mem. lense has been unlocked (game completed)
	public void updateUStatus()
	{
		MemoryLense.lense.totalUnlocked = 1;
		MemoryLense.lense.unlockedStatus1 = 1;
	}
}
