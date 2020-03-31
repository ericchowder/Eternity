using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	public static float timeLeft;
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0)
		{
			SceneManager.LoadScene("Eta's Room");
		}
	}

	public static void UpdateTimeLeft(float time)
	{
		timeLeft = time;
	}
}
