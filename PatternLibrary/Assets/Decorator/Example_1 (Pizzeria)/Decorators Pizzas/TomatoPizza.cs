using UnityEngine;

public class TomatoPizza : PizzaDecorator
{
    private const string ADDITIONAL_DESCIPTION = " Withs Tomato";




    public TomatoPizza(Pizza pizza) : base(pizza.Name + ADDITIONAL_DESCIPTION, pizza)
    {

    }




    public override int GetCost()
    {
        return _pizza.GetCost() + 20;
    }
}
