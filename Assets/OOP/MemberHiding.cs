using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humanoid
{
    //Base version of the Yell method
    public void Yell()
    {
        Debug.Log("Humanoid version of the Yell() method");
    }
}
public class EnemY : Humanoid
{
    //This hides the Humanoid version.
    new public void Yell()
    {
        Debug.Log("Enemy version of the Yell() method");
    }
}
public class Orc : EnemY
{
    //This hides the Enemy version.
    new public void Yell()
    {
        Debug.Log("Orc version of the Yell() method");
    }
}
public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new EnemY();
        Humanoid orc = new Orc();

        //Notice how each Humanoid variable contains
        //a reference to a different class in the
        //inheritance hierarchy, yet each of them
        //calls the Humanoid Yell() method.
        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
