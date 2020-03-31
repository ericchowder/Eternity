using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenStory : MonoBehaviour {

	public GameObject storyBackground;
	public GameObject storyText;

	public void open()
	{
		storyText.SetActive(true);
		storyBackground.SetActive(true);
	}
}
