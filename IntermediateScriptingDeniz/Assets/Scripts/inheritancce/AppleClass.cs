using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is the derived class whis is
//also know as the child class.
public class Apple : Fruit
{
    //this is the first constructor for the apple class.
    //it calls the parent constructor immediatly,even
    //before it runs
    public Apple()
    {
        //noticce how apple has accesss to the public variable
        //color, which is a part of the parent fruit class.
        color = "red";
        Debug.Log("1st Apple Constructor Called");
    }

    //this is the second constructor for the apple class.
    //it sspecifiess which parent constructor will be called
    //using the "base" keyword.
    public Apple(string newColor) : base(newColor)
    {
        //notice how this constructor dosent set the color
        //since the base constructor sets the color that
        //is passed as an argument.
        Debug.Log("2nd Apple Consstructor Called");
    }
}
