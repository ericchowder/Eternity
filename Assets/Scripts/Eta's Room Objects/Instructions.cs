using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour{
	public GameObject instructions;
	public GameObject background;

	public GameObject exit;

	void Start()
	{
		ShowInstructions();

		
	}

	public void ShowInstructions()
    {
		instructions.SetActive(true);
		background.SetActive(true);

		exit.SetActive(true);
    }

}
