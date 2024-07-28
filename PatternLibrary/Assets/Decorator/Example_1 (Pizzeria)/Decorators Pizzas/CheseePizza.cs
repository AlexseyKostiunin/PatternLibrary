using UnityEngine;

public class CheseePizza : PizzaDecorator
{
    private const string ADDITIONAL_DESCIPTION = " Withs Chesee";




    public CheseePizza(Pizza pizza) : base(pizza.Name + ADDITIONAL_DESCIPTION, pizza)
    {

    }




    public override int GetCost()
    {
        return _pizza.GetCost() + 15;
    }
}
