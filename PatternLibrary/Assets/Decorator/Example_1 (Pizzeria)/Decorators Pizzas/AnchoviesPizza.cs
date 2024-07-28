using UnityEngine;

public class AnchoviesPizza : PizzaDecorator
{
    private const string ADDITIONAL_DESCIPTION = " Withs Anchovies";




    public AnchoviesPizza(Pizza pizza) : base(pizza.Name + ADDITIONAL_DESCIPTION, pizza)
    {

    }




    public override int GetCost()
    {
        return _pizza.GetCost() + 10;
    }
}
