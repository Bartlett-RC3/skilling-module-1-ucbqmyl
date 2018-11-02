using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4RayCastingScriptHomework : MonoBehaviour {
    public bool seen = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (seen)
        {
            transform.localScale = new Vector3(0, 0, 0);
        }
        seen = false;


    }
}
