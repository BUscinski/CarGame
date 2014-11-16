using UnityEngine;
using System.Collections;

public class ControllerWrapper : MonoBehaviour {
//	public GameObject Cube;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			Debug.Log ("X");
		}
		if(Input.GetButtonDown("Fire2"))
		{
			Debug.Log ("Circle");
		}
		if(Input.GetButtonDown ("Fire3"))
		{
			Debug.Log ("Square");
		}
		if (Input.GetButtonDown ("Jump"))
		{
			Debug.Log ("Triangle");
		}
//		Cube.rigidbody.AddForce (new Vector3(Input.GetAxis ("LeftStick") * 10, 0, 0));
	}
}
