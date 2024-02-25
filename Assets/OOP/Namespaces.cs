using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using static UnityEditor.Progress;

public class PlayerMovement : MonoBehaviour
/* без using UnityEngine; можна:
   public class PlayerMovement : UnityEngine.MonoBehaviour
    {}*/
{
    void Start()
    {
        float speed = Random.value;
        // …
    }
}
//Створення власного namespace
namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        // ...
    }
}
//Оголошення вкладених namespace
namespace EditorTools.MapCreation
{
    public class Drawing
    {
        // ...
    }
}
