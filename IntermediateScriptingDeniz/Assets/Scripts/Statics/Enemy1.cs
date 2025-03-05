using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1
{
    //Static variables are shared across all instances
    //of a class

    public static int enemyCount = 0;

    public static int enemyCount2 = 0;

  public Enemy1()
    {
        //Increment the static variiable to know how many
        //objects of this class have been created.
        enemyCount++;
    }
}
