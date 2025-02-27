using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is the base class whicch is
//also known as the parent class.
public class Fruit
{
    public string color;

    //this is the first constructor for the fruit class
    //and is not inherited by any derived classes.
    public Fruit()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    //this is the second constructor for the fruit class
    // and is not inherited by any derived classes.
    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}

