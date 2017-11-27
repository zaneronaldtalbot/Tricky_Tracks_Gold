using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineLightFlash : MonoBehaviour {

    private Light redLight;
    public float coolDown = 0.5f;
    private float cdCopy;
    private bool turnOn = false, turnOff = false;

	// Use this for initialization
	void Start () {
        redLight = GetComponent<Light>();
        cdCopy = coolDown;
        turnOn = true;
	}
	
	// Update is called once per frame
	void Update () {
        coolDown -= Time.deltaTime;
        if (coolDown < 0)
        {
            coolDown = cdCopy;


            if (turnOn)
            {
                turnOn = false;
                turnOff = true;
                redLight.enabled = true;
            }
            else if (turnOff)
            {
                turnOn = true;
                turnOff = false;
                redLight.enabled = false;
            }
        }
	}
}
