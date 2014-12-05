using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Application.targetFrameRate = 300;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown (KeyCode.Space))
		{
			if(Application.loadedLevelName == "Katamari")
			{
				Application.LoadLevel ("Katamari");
			}
			if(Application.loadedLevelName == "Explode")
			{
				Application.LoadLevel ("Explode");
			}
		}
	}
}
