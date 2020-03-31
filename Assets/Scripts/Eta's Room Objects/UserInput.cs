using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UserInput : MonoBehaviour
{
	public string userInput;

	public GameObject text;

	public GameObject desktop;
	public GameObject mydiarybtn;
	public GameObject memaccessbtn;
	public GameObject powerBtn;

	public void GetInput(string userInput)
	{
		//Debug.Log(userInput);
		//check if user's answer is correct
		if (userInput.Equals("5201"))
		{
			GameObject.Find("LoginScreen").SetActive(false);
			GameObject.Find("InputField").SetActive(false);
			GameObject.Find("UserInput").SetActive(false);

			//players have access to the desktop
			desktop.SetActive(true);
			mydiarybtn.SetActive(true);
			memaccessbtn.SetActive(true);
			powerBtn.SetActive(true);

		}

		else
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
