using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timeline : MonoBehaviour {

	public Text timelineText;

	public GameObject timelineObj;
	public GameObject timelineTextbox;

	//where the player is time travelling to
	//the past or present
	public string timeline;

	// Use this for initialization
	void Start () {
		ShowTimeline();
	}

	//let players know if they are in the past or present
	public void ShowTimeline()
	{
		timelineText.text = timeline;

		StartCoroutine(ShowAndHide(timelineObj, timelineTextbox));
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
