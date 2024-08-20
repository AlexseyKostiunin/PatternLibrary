using UnityEngine;

public abstract class PizzaDecorator : Pizza
{
    protected Pizza _pizza;




    protected PizzaDecorator(string newNamePizza, Pizza pizza) : base(newNamePizza)
    {
        _pizza = pizza;
    }
}
