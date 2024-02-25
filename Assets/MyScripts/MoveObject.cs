using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public Vector3 moveToPosition;
    public int changesAmount;
    private Vector3 positionChange;
    private int currentChangeCounter;
    // Start is called before the first frame update
    void Start()
    {
        positionChange.x = moveToPosition.x / changesAmount;
        positionChange.y = moveToPosition.y / changesAmount;
        positionChange.z = moveToPosition.z / changesAmount;
        ResetcurrentChangeCounter();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentChangeCounter < 0)
        {
            transform.position += positionChange;
            currentChangeCounter++;
        }
        else if (currentChangeCounter == changesAmount)
        {
            ResetcurrentChangeCounter();
        }
        else
        {
            transform.position -= positionChange;
            currentChangeCounter++;
        }
    }
    void ResetcurrentChangeCounter()
    {
        currentChangeCounter = -changesAmount;
    }
}
