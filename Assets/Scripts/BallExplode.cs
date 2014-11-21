using UnityEngine;
using System.Collections;

public class BallExplode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag != gameObject.tag && col.gameObject.tag != "default")
		{
			Debug.Log (col.rigidbody.name);
			col.rigidbody.mass = 1.0f;
			col.rigidbody.freezeRotation = false;
			col.rigidbody.AddForce (gameObject.rigidbody.velocity.normalized * 10000);
		}
	}
}
