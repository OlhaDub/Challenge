using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChange : MonoBehaviour
{
    public Vector3 maxAddedSize;
    public int changesAmount;
    private Vector3 scaleChange;
    private int currentChangeCounter;
    // Start is called before the first frame update
    void Start()
    {
        scaleChange.x = maxAddedSize.x / changesAmount;
        scaleChange.y = maxAddedSize.y / changesAmount;
        scaleChange.z = maxAddedSize.z / changesAmount;
        ResetcurrentChangeCounter();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentChangeCounter<0)
        {
            transform.localScale += scaleChange;
            currentChangeCounter++;
        }
        else if (currentChangeCounter == changesAmount)
        {
            ResetcurrentChangeCounter();
        }
        else
        {
            transform.localScale -= scaleChange;
            currentChangeCounter++;
        }
    }
    void ResetcurrentChangeCounter()
    {
        currentChangeCounter = -changesAmount;
    }
}
