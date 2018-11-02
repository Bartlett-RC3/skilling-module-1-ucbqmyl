using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Session4MYL : MonoBehaviour {

    // Variables
    public GameObject prefabReference;
    IEnumerator createPrefabs;

    // Use this for initialization
    void Start () 
    {
        for (int i = 0; i < 10;i++)
        {
            Vector3 prefabPosition = new Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-10, 10));
            Quaternion prefabRotation = Quaternion.identity;
            GameObject myPrefab = Instantiate(prefabReference, prefabPosition, prefabRotation);

            foreach (Transform child in myPrefab.transform) //因為shpere是在子資料裡，所以要變球體顏色就要用child
            {
                child.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 1);
            }
            myPrefab.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);//要改變cube（屬於parent）顏色
        }

   
        createPrefabs = DropPrefabFromHeight();

    }
	
    private void Instantiate()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(createPrefabs);
        Debug.Log(Time.time);
        if (Time.time > 5)
        {
            StopCoroutine(createPrefabs);
            StopAllCoroutines();
        }

    }
     
    //Implement the coroutine
    IEnumerator DropPrefabFromHeight()
    {
        while(true)//括號裡是設定condition //這個loop是infinite
        {
            Vector3 prefabPos = new Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(0, 10), UnityEngine.Random.Range(-10, 10));
            Quaternion prefabRot = new Quaternion(UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), UnityEngine.Random.Range(0, 90), 1);
            Instantiate(prefabReference, prefabPos, prefabRot);
            yield return new WaitForSeconds(5);
        }

    }

}
