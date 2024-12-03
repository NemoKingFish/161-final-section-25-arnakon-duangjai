using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Circle : Main
{
    void Start()
    {
        Debug.Log("Drawing side");
        CalculateArea();
    }

    private float raidus = 4;
}
