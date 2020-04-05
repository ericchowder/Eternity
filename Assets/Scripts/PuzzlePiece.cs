using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PuzzlePiece : MonoBehaviour {
	//holds reference to this object
	//singleton
	public static PuzzlePiece puzzlePieces;
	//keep track of whether item has been obtained or not
	public int key;
	public int wire;
	public int chipcard;
	public int piece4;



		void Awake()
	{
		//if there is no current singleton, make this the singleton
		if (puzzlePieces == null)
		{
			DontDestroyOnLoad(gameObject);
			puzzlePieces = this;
		}

		//if one already exists, make sure this does not become the current singleton
		//only want one to exist
		else if(puzzlePieces != this)
		{
			Destroy(gameObject);
		}
		
	}

}
