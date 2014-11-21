using UnityEngine;
using System.Collections;

public class BallExplode : MonoBehaviour {
	private bool hasBeenHit = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag != gameObject.tag && col.gameObject.tag != "Default" && col.gameObject.name != "Ball")
		{
			Debug.Log (col.rigidbody.name);
			col.rigidbody.mass = 1.0f;
			col.rigidbody.freezeRotation = false;
		//	col.rigidbody.AddForce (gameObject.rigidbody.velocity.normalized * 10000);
		//	col.transform.parent = this.transform;
		//	col.transform.localPosition = Vector3.zero;
		//	col.collider.enabled = false;
			Destroy(col.transform.GetComponent<Rigidbody>());
			col.gameObject.AddComponent<FixedJoint>().connectedBody = rigidbody;
			hasBeenHit = true;
		}
	}
}
