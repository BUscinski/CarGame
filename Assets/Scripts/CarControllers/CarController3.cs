using UnityEngine;
using System.Collections;

public class CarController3 : MonoBehaviour {
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
		if(Input.GetButtonDown ("Gas3")){
			FrontLeftTire.motorTorque = motorTorque;
			FrontRightTire.motorTorque = motorTorque;	
		}
		if(Input.GetButtonUp ("Gas3")){
			FrontLeftTire.motorTorque = 0;
			FrontRightTire.motorTorque = 0;
		}
		if(Input.GetButtonDown ("Reverse3")){
			FrontLeftTire.motorTorque = -motorTorque;
			FrontRightTire.motorTorque = -motorTorque;
		}
		if(Input.GetButtonUp ("Reverse3"))
		{
			FrontLeftTire.motorTorque = 0;
			FrontRightTire.motorTorque = 0;
		}
		if(Input.GetKeyUp (KeyCode.S)){
			FrontLeftTire.motorTorque = 0;
			FrontRightTire.motorTorque = 0;
		}
		FrontLeftTire.steerAngle = (Input.GetAxis("Horizontal3") * 20);
		FrontRightTire.steerAngle = (Input.GetAxis ("Horizontal3") * 20);
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
