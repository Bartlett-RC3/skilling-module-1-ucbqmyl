using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Session1Homework : MonoBehaviour 
{
    public int myInt = 10;
    public float myFloat = 20;
    public string myName = "Kevin";
    public double[] myArray = { 19, 6, 1995, 84, 170, 55 };
    public List<int> myList = new List<int>();
    public Dictionary<string, string> color = new Dictionary<string, string>();


    // Use this for initialization
    void Start()
    {
        myList.Add(2);
        myList.Add(3);
        myList.Add(5);
        myList.Add(7);
        myList.Add(11);

        color.Add("blue", "sky");
        color.Add("red", "apple");
        color.Add("yellow", "banana");
        color.Add("green", "grass");
        color.Add("purple", "grapes");

        Debug.Log(myInt);
        Debug.Log(myFloat);
        Debug.Log(myName);

        Debug.Log(myList[0].ToString());
        Debug.Log(myList[3].ToString());
        Debug.Log(myList[4].ToString());

        Debug.Log("My birthday is " + myArray[0].ToString() + myArray[1].ToString() + myArray[2].ToString());
        Debug.Log("My height is " + myArray[4].ToString() + "cm");
        Debug.Log("my weight is " + myArray[5].ToString() + "kg");

        if (color.ContainsKey("blue"))
        {
            Debug.Log(color.Values + " is blue.");
        }

        int a = myList[0];
        int b = myList[3];
        int addition = a + b;
        Debug.Log(a + "+" + b + "=" + addition);
    }

    
}
