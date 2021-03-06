﻿using UnityEngine;
using System.Collections;

public class BallExplode : MonoBehaviour {
	public AudioClip carExploding;
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
				col.rigidbody.mass = 1.0f;
				col.rigidbody.AddForce (gameObject.rigidbody.velocity.normalized * 10000);
			
				if(col.transform.GetComponentInChildren<Exploder>())
				{
					col.transform.GetComponentInChildren<Exploder>().Explode();
				}
				GetComponent<AudioSource>().PlayOneShot(carExploding);
			}
		}
	}
	public void SetHasBeenHit(bool x)
	{
		hasBeenHit = x;
	}
}
