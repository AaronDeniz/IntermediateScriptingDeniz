using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass1 : MonoBehaviour
{
    //Here is a generic method. notice the generic
    //type T. this T will be replaced at runtime
    //with an actual type.
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
