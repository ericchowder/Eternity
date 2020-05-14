using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomStory : MonoBehaviour {

	public GameObject page1;
	public GameObject page2;
	public GameObject page3;

	public void deactivatePage1()
	{
		page1.SetActive(false);
		page2.SetActive(true);
	}
	public void deactivatePage2()
	{
		page2.SetActive(false);
		page3.SetActive(true);
	}

	public void reactivatePage1()
	{
		page1.SetActive(true);
		page2.SetActive(false);
	}

	public void reactivatePage2()
	{
		page2.SetActive(true);
		page3.SetActive(false);
	}

	public void loadTextStory()
	{
		SceneManager.LoadScene("RoomTextStory");
	}
}
