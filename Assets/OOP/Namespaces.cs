using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = UnityEngine.Random;
using static UnityEditor.Progress;

public class PlayerMovement : MonoBehaviour
/* ��� using UnityEngine; �����:
   public class PlayerMovement : UnityEngine.MonoBehaviour
    {}*/
{
    void Start()
    {
        float speed = Random.value;
        // �
    }
}
//��������� �������� namespace
namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        // ...
    }
}
//���������� ��������� namespace
namespace EditorTools.MapCreation
{
    public class Drawing
    {
        // ...
    }
}
