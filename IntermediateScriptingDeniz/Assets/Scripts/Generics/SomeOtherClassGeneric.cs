using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClassGeneric : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass1 myClass = new SomeClass1();

        //In order to use this method you musst
        //tell the method what type to replace
        //T with
        myClass.GenericMethod<int>(5);
    }

}
