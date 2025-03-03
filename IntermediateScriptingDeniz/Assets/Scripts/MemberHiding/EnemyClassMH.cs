using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Humanoid 
{
    //this hides the humanoid version.
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }

}
