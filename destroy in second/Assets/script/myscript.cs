using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class myscript : MonoBehaviour {
    public FixedJoystick movejoystick;
    public FixedButton jumpbutton;
    public FixedTouchField touchfield;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var fps = GetComponent<RigidbodyFirstPersonController>();
        fps.RunAxis = movejoystick.inputVector;
        fps.JumpAxis = jumpbutton.Pressed;
        fps.mouseLook.LookAxis = touchfield.TouchDist;
	}
}
