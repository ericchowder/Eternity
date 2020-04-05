using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//template for when asking users questions
public class UserConfirmation : MonoBehaviour {
	public GameObject yesButton;
	public GameObject noButton;

	public GameObject questionText;
	public GameObject textbox;

	public void Appear()
	{
		yesButton.SetActive(true);
		noButton.SetActive(true);

		questionText.SetActive(true);
		textbox.SetActive(true);
	}

}
