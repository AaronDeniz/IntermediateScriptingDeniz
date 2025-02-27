using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    //Static variables are shared across all instancces
    //of a class
    public static int playerCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        //increment the static variable to know how many
        //objects of this cclass have been created
        playerCount++;
    }

}
