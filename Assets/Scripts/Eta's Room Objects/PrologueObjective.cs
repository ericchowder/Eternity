using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrologueObjective : MonoBehaviour {
	//assets for players' objective
	public Text objvText;

	public GameObject objvTextObj;
	public GameObject objvTextbox;

	
	public void ShowObjective()
	{
		objvText.text = "Objective: Who am I?";

		StartCoroutine(ShowAndHide(objvTextObj, objvTextbox));
	}

	IEnumerator ShowAndHide(GameObject text, GameObject textbox)
	{
		text.SetActive(true);
		textbox.SetActive(true);
		yield return new WaitForSeconds(1.5f);
		text.SetActive(false);
		textbox.SetActive(false);
	}
}
