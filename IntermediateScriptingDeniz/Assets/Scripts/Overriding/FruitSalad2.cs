using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple myApple = new Apple();

        //Notice that the Apple version of the methods
        //override the fruit versions. also notice that
        //since the apple versions call the fruit version with
        //the "base" keyword, both are called.
        myApple.SayHello();
        myApple.Chop();

        //Overriding is also useful in a polymorphic situation.
        //Since the methods of the fruit class are "virtual" and
        //the methods of the apple class are "override", when we
        //upcast an apple into a fruit, the apple version of the
        //Methods are used
        Fruit myFruit = new Apple();
        myFruit.SayHello();
        myFruit.Chop();

    }

}
