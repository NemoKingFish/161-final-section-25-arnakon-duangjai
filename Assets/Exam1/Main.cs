using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEditor.TextCore.Text;
using UnityEngine;

public abstract class Main : MonoBehaviour
{
    protected string shapeName;

    public void Init(string idk)
    {

    }

    public abstract float CalculateArea()
    {  
        return; 
    }

    public virtual void Resize()
    {
        Debug.Log("show text");
    }


    public void shared()
    {

    }

    void Start()
    {
        
    }
}
