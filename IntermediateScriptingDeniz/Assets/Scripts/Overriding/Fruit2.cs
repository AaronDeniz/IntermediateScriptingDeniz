using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit2 : MonoBehaviour
{
    public Fruit2 ()
    {
        Debug.Log("1st Fruit Constructor Called");
    }

    //These methods are Virtual and thus can be ovewrriden
    //in child classes
    public virtual void Chop ()
    {
        Debug.Log("The fruit has been chopped.");
    }

    public virtual void SayHello ()
    {
        Debug.Log("Hello, I am a fruit");
    }

}
