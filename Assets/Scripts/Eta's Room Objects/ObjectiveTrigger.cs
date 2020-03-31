using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectiveTrigger : MonoBehaviour
{

    //assets for players' objective
    public Text objvText;

    public GameObject objvTextObj;
    public GameObject objvTextbox;

    //assets for hints that players can use
    public Text hintText;

    public GameObject hintTextObj;
    public GameObject hintTextbox;

    public GameObject headshot;

    public GameObject continueBtn;
    public GameObject exitBtn;

	public Queue<string> sentences;

    public void ShowObjective(string objective)
    {
        objvText.text = objective;

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

    public void ShowHint(Dialogue dialogue)
    {
		//make textbox and dialogue appear onto screen
		continueBtn.SetActive(true);

		hintTextObj.SetActive(true);
		hintTextbox.SetActive(true);

		headshot.SetActive(true);

		sentences.Clear();

		//iterates through queue that is holding the dialogue sentences(?)
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
		return;
	}

	void Start()
	{
		sentences = new Queue<string>();
	}


	public void DisplayNextSentence()
	{
		if (sentences.Count == 1)
		{
			exitBtn.SetActive(true);
			continueBtn.SetActive(false);
		}

		string sentenceDisplayed = sentences.Dequeue();
		StopAllCoroutines(); //immediately stops letters from appearing one by one
		StartCoroutine(TypeSentence(sentenceDisplayed)); //trigger letters to start appearing one by one

		return;
	}

	IEnumerator TypeSentence(string sentence)
	{
		//make letters in dialogue appear one by one
		hintText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			hintText.text += letter;
			yield return null;
		}
	}
}
