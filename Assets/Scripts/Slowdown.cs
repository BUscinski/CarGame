using UnityEngine;
using System.Collections;

public class Slowdown : MonoBehaviour {
	private bool isSlowingDown = false;
	
	// Update is called once per frame
	void OnTriggerEnter(Collider col)
	{
		if(col.tag != this.tag && col.tag != "Default" && !isSlowingDown)
		{
			isSlowingDown = true;
			Time.timeScale = 0.25f;
		}
	}
	void OnTriggerExit(Collider col)
	{
		if(isSlowingDown)
		{
			isSlowingDown = false;
			Time.timeScale = 1.0f;
		}
	}
}
