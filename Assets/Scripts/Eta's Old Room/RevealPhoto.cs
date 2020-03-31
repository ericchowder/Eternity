using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RevealPhoto : MonoBehaviour {

	//keeps track of how many times the object has been clicked
	private int clicked = 0;

	public GameObject photo1;
	public GameObject photo2;
	public GameObject photo3;

	private GameObject photo; //variable for keeping which photo to display when clicked

	public GameObject button;

	public void Check()
    {
		if(PuzzlePiece.puzzlePieces.key == 0)
		{
			if (clicked == 0)
			{
				photo = photo1;
				clicked = 1;
			}

			else if (clicked == 1)
			{
				photo = photo2;
				clicked = 2;
			}

			else if (clicked == 2)
			{
				photo = photo3;
				button.SetActive(true);
			}
		}

		else
		{
			photo = photo1;
		}

		photo.SetActive(true);
    }

}
