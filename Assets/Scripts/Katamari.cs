using UnityEngine;
using System.Collections;

public class Katamari : MonoBehaviour {
	private bool hasBeenHit = false;
	// Use this for initialization
	void Start () {
		if(gameObject.tag != "Untagged")
		{
			hasBeenHit = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col)
	{
		if(hasBeenHit == true)
		{
			if(col.gameObject.tag != gameObject.tag && col.gameObject.tag != "Default" && col.gameObject.name != "Ball")
			{
				Debug.Log (col.rigidbody.name);
				col.rigidbody.mass = 1.0f;
				//	col.rigidbody.AddForce (gameObject.rigidbody.velocity.normalized * 10000);
				//	col.transform.parent = this.transform;
				//	col.transform.localPosition = Vector3.zero;
				//	col.collider.enabled = false;
				
				Destroy(col.transform.GetComponent<Rigidbody>());
				col.gameObject.AddComponent<FixedJoint>().connectedBody = rigidbody;
				hasBeenHit = true;
				col.transform.tag = this.tag;
				Transform[] children = col.transform.GetComponentsInChildren<Transform>();
				for(int i = 0; i < children.Length; i++)
				{
					children[i].tag = this.tag;
				}
				col.transform.GetComponent<Katamari>().SetHasBeenHit(true);
				Debug.LogError ("Treu");
			}
		}
	}
	public void SetHasBeenHit(bool x)
	{
		hasBeenHit = x;
	}
}
