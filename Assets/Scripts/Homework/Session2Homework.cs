using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Session2Class;

public class Session2Homework : MonoBehaviour 
{
    public int number1 = 5;
    public int number2 = 8;
    public int number3 = 10;
    public bool boolean = false;

    string[] color = { "red", "orange", "yellow", "green", "blue", "purple" };

    List<Dog> DogList = new List<Dog>();

	// Use this for initialization
	void Start () 
    {
        if(number1<number2)
        {
            Debug.Log("Number 2 is bigger than number 1.");
        }
        else
        {
            Debug.Log("Number 1 is bigger than number 2");
        }


        if(number1<number2 && boolean==true)
        {
            Debug.Log("success");
        }
        else
        {
            Debug.Log("failed");
        }


        if(number2<number3 || boolean==true)
        {
            Debug.Log("50% success");
        }

        string a =(number1 < number2) ? "true" : "false";


        for (int i = 0;i <= color.Length-1;i++)
        {
            Debug.Log("The color is "+color[i]);

        }
        foreach(string colorName in color)
        {
            Debug.Log("The color name is " + colorName);
        }

        Dog A = new Dog("Happy", "Lin", "Black", 2, 10);
        Debug.Log(A.GetDogName());
        Debug.Log(A.GetDogOwnerName());
        Debug.Log(A.GetDogColor());
        Debug.Log(A.GetDogAge());
        Debug.Log(A.GetDogweight());

    }
	
	
}
