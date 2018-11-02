using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour 
{
    public GameObject prefab;
    public Material prefabColor;


	// Use this for initialization
	void Start () 
    {
        Instantiate(prefab,this.transform);

    }
	
	// Update is called once per frame
	void Update () 
    {

        //Create a cube and move it across the screen
        this.transform.Translate(Vector3.right * Time.deltaTime);


        //Why is this way wrong??
        if(Input.GetKey(KeyCode.Space))
        {
            this.transform.GetChild(0).GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }


        //Create a cube and change its colour when key is pressed or mouse is pressed
        /*if (Input.GetKey(KeyCode.Space))
        {
            prefabColor.color = new Color(Random.value, Random.value, Random.value);
        }*/

    }
}
