using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Session4Homework : MonoBehaviour 
{
    public GameObject prefab;
    public Material prefabMaterial;

    public int count = 10;
    public int spacingX = 5;

    IEnumerator changePrefab;


	// Use this for initialization
	void Start () 
    {
        for (int i = 0; i < count;i++)
        {
            GameObject myPrefab = Instantiate(prefab,this.transform);
            Vector3 pos = new Vector3(i * spacingX, 0f, 0f);
            myPrefab.transform.localPosition = pos;

        }

        changePrefab = ChangeColor();
        StartCoroutine(changePrefab);
    }
	
	// Update is called once per frame
	void Update () 
    {
       
        Debug.Log(Time.time);
    }

    IEnumerator ChangeColor()
    {
        while(true)
        {

            prefabMaterial.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
            yield return new WaitForSeconds(2);
            //yield return StartCoroutine(changePrefab);
        }
    }
}
