using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Session4RayCastingHomework : MonoBehaviour 
{



	// Use this for initialization
	void Start () 
    {
    }
	
	// Update is called once per frame
	void Update () 
    {

        Vector3 rayDirect = transform.forward;
        RaycastHit objectinfront;
        if (Physics.Raycast(transform.position,rayDirect,out objectinfront))
        {
            objectinfront.transform.GetComponent<Session4RayCastingScriptHomework>().seen = true;
        }
    }


}
