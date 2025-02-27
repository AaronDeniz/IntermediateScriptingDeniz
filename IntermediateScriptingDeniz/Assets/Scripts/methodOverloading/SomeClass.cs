using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass
{
    //The first add method has a signature of
    //"Add(int, int)". this signature must be unique.
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    //this second add method has a signature of
    //"Add(string, string)". Again, this must be unique.
    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }

}
