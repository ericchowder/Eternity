using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTrigger : MonoBehaviour {

	public BackgroundObjects objsToShow;

	public void ShowObjs()
	{
		for (int i = 0; i < objsToShow.backgroundObjs.Length; i++)
		{
			objsToShow.backgroundObjs[i].SetActive(true);
		}
	}
}
