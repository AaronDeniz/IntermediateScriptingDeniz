using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    internal static int playerCount;

    //Member variables can be referred to as
    // fields
    private int experience;

    //Experience is a basic property
    public int Experience
    {
        get
        {
            //some other code
            return experience;
        }
        set
        {
            //some other code
            experience = value;
        }
    }

    //Level is a property that converts experience 
    //points into leve of a player automatically
    public int Level
    {
        get
        {
            return experience / 1000;
        }
        set
        {
            experience = value * 1000;
        }
    }

    //this is an example of an auto-implemented
    //property
    public int Health{ get; set;}
}