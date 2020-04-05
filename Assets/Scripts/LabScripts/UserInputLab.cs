using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UserInputLab : MonoBehaviour
{
	public string userInput;

	public GameObject text;

	public GameObject computer;

	public Dialogue dialogue;

	public void GetInput(string userInput)
	{
		//Debug.Log(userInput);
		//check if user's answer is correct
		if (userInput.ToLower().Equals("nabonpobbaaiot") && Input.GetKey(KeyCode.KeypadEnter) == true)
		{
			GameObject.Find("LoginScreen").SetActive(false);
			GameObject.Find("InputField").SetActive(false);
			

			MemoryLense.lense.obtainedStatus3 = 1;

			computer.GetComponent<ItemObtained>().TriggerItemObtained();
			computer.GetComponent<DialogueTrigger>().dialogue = dialogue;
			computer.GetComponent<DialogueTrigger>().TriggerDialogue();

		}

		else if (!userInput.ToLower().Equals("nabonpobbaaiot") && !userInput.Equals("") && Input.GetKey(KeyCode.KeypadEnter) == true)
		{
			StartCoroutine(ShowAndHide(text));
		}


	}

	IEnumerator ShowAndHide(GameObject gObject)
	{
		gObject.SetActive(true);
		yield return new WaitForSeconds(0.5f);
		gObject.SetActive(false);
	}



}
