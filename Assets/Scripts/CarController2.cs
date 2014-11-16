using UnityEngine;
using System.Collections;

public class CarController2 : MonoBehaviour {
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
		if(Input.GetKeyDown (KeyCode.UpArrow)){
			FrontLeftTire.motorTorque = motorTorque;
			FrontRightTire.motorTorque = motorTorque;	
		}
		if(Input.GetKeyUp (KeyCode.UpArrow)){
			FrontLeftTire.motorTorque = 0;
			FrontRightTire.motorTorque = 0;
		}
		if(Input.GetKeyDown (KeyCode.DownArrow)){
			FrontLeftTire.motorTorque = -motorTorque;
			FrontRightTire.motorTorque = -motorTorque;
		}
		if(Input.GetKeyUp (KeyCode.DownArrow)){
			FrontLeftTire.motorTorque = 0;
			FrontRightTire.motorTorque = 0;
		}
		if(Input.GetKey (KeyCode.LeftArrow)){
			FrontLeftTire.steerAngle = -20;
			FrontRightTire.steerAngle = -20;
		}
		if(Input.GetKey (KeyCode.RightArrow)){
			FrontLeftTire.steerAngle = 20;
			FrontRightTire.steerAngle = 20;
		}
		if((!Input.GetKey (KeyCode.RightArrow)) && (!Input.GetKey (KeyCode.LeftArrow)))
		{
			FrontLeftTire.steerAngle = 0;
			FrontRightTire.steerAngle = 0;
		}
	}
}
