using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructions_screen : MonoBehaviour {

	public GameObject instructionUI;

	public void continueButton() {
		instructionUI.SetActive (false);
	}
}
