using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //lets illustrate inheritance with the
        //default constructors.
        Debug.Log("Creating the fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myApple = new Apple();

        //call the method of the fruit class.
        myFruit.SayHello();
        myFruit.Chop();

        //call the method of the apple class.
        //notice how the class apple access to all
        //of the public methods of classs fruit
        //myApple.SayHello();
        myApple.Chop();

        //now lets illustrate inheritance with the
        //constructors that read in a string.
        Debug.Log("Creating the fruit");
        myFruit = new Fruit("yellow");
        myApple = new Apple("green");

        //call the methods of the fruit class.
        myFruit.SayHello();
        myFruit.Chop();

        //call the methods of the apple class.
        //notice how class apple access to all
        //of the public methods of class fruit.
        myApple.SayHello();
        myApple.Chop();
    }
}
