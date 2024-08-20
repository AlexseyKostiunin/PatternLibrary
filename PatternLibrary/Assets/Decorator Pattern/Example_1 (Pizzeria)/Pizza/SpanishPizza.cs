using UnityEngine;

public class SpanishPizza : Pizza
{
    private const string NAME = "Spanish Pizza";




    public SpanishPizza() : base(NAME)
    {

    }




    public override int GetCost()
    {
        return 25;
    }
}
