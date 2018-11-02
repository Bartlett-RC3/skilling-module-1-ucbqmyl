using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4RayCastingMYL : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        Vector3 raycastingDirection = transform.forward;

        RaycastHit objectInfront;

        if(Physics.Raycast(transform.position,raycastingDirection,out objectInfront))
        {
            Debug.Log("Object in front is:" + objectInfront.transform.name);
            objectInfront.transform.GetComponent<ListenScript>().seen = true;
        }


    }
}
