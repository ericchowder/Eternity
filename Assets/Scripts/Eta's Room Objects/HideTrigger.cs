using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideTrigger : MonoBehaviour {

	public BackgroundObjects objsToHide;

	public void HideObjs()
	{
		for (int i = 0; i < objsToHide.backgroundObjs.Length; i++)
		{
			objsToHide.backgroundObjs[i].SetActive(false);
		}
	}

}
