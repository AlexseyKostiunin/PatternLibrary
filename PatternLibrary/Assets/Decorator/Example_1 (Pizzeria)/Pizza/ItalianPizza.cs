using UnityEngine;

public class ItalianPizza : Pizza
{
    private const string NAME = "Italian Pizza";




    public ItalianPizza() : base(NAME)
    {

    }




    public override int GetCost()
    {
        return 30;
    }
}
