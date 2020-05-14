using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ElevatorStory : MonoBehaviour {

	public GameObject page1;
	public GameObject page2;
	public GameObject page3;
	public GameObject page4;
	public GameObject page5;
	public GameObject page6;

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
	public void deactivatePage3()
	{
		page3.SetActive(false);
		page4.SetActive(true);
	}
	public void deactivatePage4()
	{
		page4.SetActive(false);
		page5.SetActive(true);
	}
	public void deactivatePage5()
	{
		page5.SetActive(false);
		page6.SetActive(true);
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

	public void reactivatePage3()
	{
		page3.SetActive(true);
		page4.SetActive(false);
	}

	public void reactivatePage4()
	{
		page4.SetActive(true);
		page5.SetActive(false);
	}

	public void reactivatePage5()
	{
		page5.SetActive(true);
		page6.SetActive(false);
	}

	public void loadTextStory()
	{
		SceneManager.LoadScene("ElevatorTextStory");
	}

	
}

