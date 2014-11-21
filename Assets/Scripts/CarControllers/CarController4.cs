using UnityEngine;
using System.Collections;

public class CarController4 : MonoBehaviour {
	public WheelCollider FrontLeftTire;
	public WheelCollider FrontRightTire;
	public WheelCollider BackLeftTire;
	public WheelCollider BackRightTire;
	
	public float motorTorque;
	public float brakeTorque;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown ("Gas4")){
			FrontLeftTire.motorTorque = motorTorque;
			FrontRightTire.motorTorque = motorTorque;	
		}
		if(Input.GetButtonUp ("Gas4")){
			FrontLeftTire.motorTorque = 0;
			FrontRightTire.motorTorque = 0;
		}
		if(Input.GetButtonDown ("Reverse4")){
			FrontLeftTire.motorTorque = -motorTorque;
			FrontRightTire.motorTorque = -motorTorque;
		}
		if(Input.GetButtonUp ("Reverse4"))
		{
			FrontLeftTire.motorTorque = 0;
			FrontRightTire.motorTorque = 0;
		}
		if(Input.GetKeyUp (KeyCode.S)){
			FrontLeftTire.motorTorque = 0;
			FrontRightTire.motorTorque = 0;
		}
		FrontLeftTire.steerAngle = (Input.GetAxis("Horizontal4") * 20);
		FrontRightTire.steerAngle = (Input.GetAxis ("Horizontal4") * 20);
		if(Input.GetKey (KeyCode.A)){
			FrontLeftTire.steerAngle = -20;
			FrontRightTire.steerAngle = -20;
		}
		if(Input.GetKey (KeyCode.D)){
			FrontLeftTire.steerAngle = 20;
			FrontRightTire.steerAngle = 20;
		}
	}
}
