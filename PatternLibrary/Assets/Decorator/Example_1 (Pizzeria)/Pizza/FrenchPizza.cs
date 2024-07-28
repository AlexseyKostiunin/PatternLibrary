using UnityEngine;

public class FrenchPizza : Pizza
{
    private const string NAME = "French Pizza";




    public FrenchPizza() : base(NAME)
    {

    }




    public override int GetCost()
    {
        return 20;
    }
}
