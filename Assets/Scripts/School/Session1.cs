//Refrences 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//Where code lives 
public class Session1 : MonoBehaviour
{
    //一開始只是先declare memory,然後要賦予itemsstart"後


    // 1.Variables
    // Scope(public/ private - we don't know from the static) -- Type -- Name -- Value(just one value)
    //如果沒有定義scope給他,會默認成private

    // Numbers
    public int myFirstIntegerNumber = 101; //make sure you end with ;
    float myFirstFloatNumber = 1.75f;

    int myInterger = 145;
    int largestInterger = int.MaxValue;
    int smallestInterger = int.MinValue;

    double myDouble = 54.3;
    double maxDouble = double.MaxValue;

    //have to add "f" behind value
    float myFloat = 32.456f;


    // Text(have to use " " to put word inside)
    public string myFirstString = "My text is somewhere.";


    // Logical variable
    bool myFirstBoolean = true;
    bool falseBoolean = false;

    // Data structures
    // Scope -- Type -- Values(can take many values)

    // 3.a.Arrays(imporatant order and size)(fixed size)
    public int[] myIntegrerArray = { 1, 2, 3, 4, 5 };
    public float[] myFloatArray = new float[5];

    int[] myIntArray = { 1, 2, 3, 4, 5, 6 };//{}列出所有數值
    int[] twentyElementsArray = new int[20];//[]列出數量

    double[] doubleArray = { 10.4, 11.23, 45, 72.9 };

    int[,] xyArray = new int[4, 5];//2D 陣列

    // 3.b.Lists(dynamic size)
    public List<int> myIntegerList = new List<int>();

    //3.c.Dictionary(organized information)(have to assign key and value)
    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();
    //Dictionary<key type, value type> movingAnimals = new Dictionary<string, string>();


    // 2.Functions
    // Scope -- Type -- Variables -- Body (Instructions)


    void Start()//搜尋dictionary裡的東西
    {
        movingAnimals.Add("flying", "eagle");
        movingAnimals.Add("flying", "eagle");
        movingAnimals.Add("walking", "human");
        movingAnimals.Add("walking", "dog");

        if(movingAnimals.ContainsKey("flying"))
        {
            Debug.Log("A flying anmal is" + movingAnimals.Values);
        }
    }

    void Start2()
    {
        //array adding values
        myIntArray[2] = 300;

        //Array retrive value(取得array中的某一數值)
        Debug.Log(myIntArray[1].ToString());

        //List adding values(增加數值只能往下增加無法從中插入)
        myIntegerList.Add(4321);
        myIntegerList.Add(41);
        myIntegerList.Add(1);

        //List retrive values
        Debug.Log(myIntegerList[2].ToString());
        Debug.Log(myIntegerList[myIntegerList.Count - 1].ToString());
        //列出list中的最後一個值，list中是從0開始，但count是從1開始，所以要-1

        //list all values
        foreach (int numbers in myIntegerList)
        {
            Console.WriteLine(numbers);
        }
        //or
        for (int i = 0; i < myIntegerList.Count; i++)
        {
            Console.WriteLine(myIntegerList[i]);
        }


    }



    // Use this for initialization
    void Start3 () {
        Debug.Log("Addition of 5 and 3 is: " + NumberAddition(5,3));
        myFloatArray[2] = 3.2f;
        myFloatArray[3] = 5.6f;
        myFloatArray[4] = 9.2f;

        myIntegerList.Add(1);
        myIntegerList.Add(2);
        myIntegerList.Add(3);
    }
	


	// Update is called once per frame
	void Update () {
        Debug.Log("Hello world!");
	}

    //Number Addition function
    //Scope -- Type -- Variables -- Body(instruction)

    float NumberAddition(float a, float b)
    {

        return a + b;
    }

    float NumberAddition2(float a, float b)
    {
        float additionResult = a + b;
        return additionResult;
    }

    void PrintSomenumbers()
    {
        Debug.Log(myIntegerList[0]);
    }


}
