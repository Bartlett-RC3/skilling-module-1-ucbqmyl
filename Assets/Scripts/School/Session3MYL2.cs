using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3MYL2 : MonoBehaviour 
{
    public GameObject cubePrefab;
    public GameObject light;
    public GameObject objectReference;
    public int spacing = 10;
    public int gridX = 10;
    public int gridY = 10;

    //private void Awake() //一開始還沒按下start就會存在的物件

       

    // Use this for initialization
    void Start () //start才會出現的物件
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Instantiate(cubePrefab, new Vector3(i * spacing, j * spacing, 0), Quaternion.identity, this.transform);
            }
        }
    }
	

	// Update is called once per frame
	void Update () 
    {
        //常用時間功能
        //Time.deltaTime
        //Time.realtimeSinceStartup
        //Time.time

        Debug.Log("This computer can render a frame in " + Time.deltaTime);
        Debug.Log("Since I started playing the game this amount of time has passed: " + Time.timeSinceLevelLoad);
        Debug.Log("Computer has counted this ammount of frames:" + Time.frameCount);


        //Translation
        // Move children gameobjects in x axis
        foreach (Transform child in this.transform) 
        {
            child.Translate(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f));
        }

        // ROTATION
        // Rotate children gameobjects around y axis
        foreach(Transform child in this.transform)
        {
            child.RotateAroundLocal(Vector3.up, Random.value);
        }

        //Scaling
        foreach(Transform child in this.transform)
        {
            child.localScale = new Vector3(Random.Range(0.1f, 2), Random.Range(0.1f, 2), Random.Range(0.1f, 2));
        }

        //Record the cubes orginal scale
        Vector3[] originalScale = new Vector3[this.transform.childCount];
        for (int i = 0; i < transform.childCount;i++)
        {
            originalScale[i] = transform.GetChild(i).localScale;
        }

        //KEYBOARD INPUT
        if (Input.GetKey(KeyCode.Space))
        {
            //If I have pressed space make temporary the cubes large!
            foreach (Transform child in this.transform)
            {
                child.localScale = child.localScale * 5f;
            }
        }
        else
        {
            for (int i = 0;i<transform.childCount;i++)
            {
                transform.GetChild(i).localScale = originalScale[i];
            }

        }

        // MOUSE PRESSED (O left, 1 right, 2 middle)
        if(Input.GetMouseButton(0))
        {
            light.GetComponent<Light>().color = new Color(Random.value, Random.value, Random.value);
        }


    }
}
