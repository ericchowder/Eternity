using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

	//public Animator animator;
	SpriteRenderer rend;

	// Use this for initialization
	void Start()
	{
		rend = GetComponent<SpriteRenderer>();

		startFading();
	}


	IEnumerator FadeInto()
	{
		for (float f = 1f; f >= -0.05f; f -= 0.05f)
		{
			Color c = rend.material.color;
			c.a = f;
			rend.material.color = c;
			yield return new WaitForSeconds(0.05f);
		}
	}

	public void startFading()
	{
		StartCoroutine("FadeInto");
	}

}
