using UnityEngine;
using System.Collections;

public class Exploder : MonoBehaviour 
{
	private void Explode()
	{
		foreach (Transform t in transform)
		{
			t.tag = "Default";
			var rb = t.gameObject.AddComponent<Rigidbody>();
			rb.constraints = RigidbodyConstraints.FreezePositionY;
			rb.AddExplosionForce(500f, t.position, 0f);
			t.gameObject.AddComponent<SphereCollider>();
		}
	}
}
