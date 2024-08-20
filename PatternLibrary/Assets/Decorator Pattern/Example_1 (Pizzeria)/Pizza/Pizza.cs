using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pizza
{
    public Pizza(string name)
    {
        Name = name;
    }




    public string Name { get; protected set; }

    public abstract int GetCost();
}
