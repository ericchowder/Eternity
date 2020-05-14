using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prologue_script : MonoBehaviour {

	public GameObject page1;
	public GameObject page2;
	public GameObject page3;
	public GameObject page4;
	public GameObject page5;
	public GameObject page6;
	public GameObject page7;
	public GameObject page8;
	public GameObject page9;

	public void deactivatePage1() {
		page1.SetActive (false);
		page2.SetActive (true);
	}
	public void deactivatePage2() {
		page2.SetActive (false);
		page3.SetActive (true);
	}
	public void deactivatePage3() {
		page3.SetActive (false);
		page4.SetActive (true);
	}
	public void deactivatePage4() {
		page4.SetActive (false);
		page5.SetActive (true);
	}
	public void deactivatePage5() {
		page5.SetActive (false);
		page6.SetActive (true);
	}
	public void deactivatePage6() {
		page6.SetActive (false);
		page7.SetActive (true);
	}
	public void deactivatePage7() {
		page7.SetActive (false);
		page8.SetActive (true);
	}
	public void deactivatePage8() {
		page8.SetActive (false);
		page9.SetActive (true);
	}
	public void loadEtaScene() {
		SceneManager.LoadScene ("Eta's Room");
	}
}
