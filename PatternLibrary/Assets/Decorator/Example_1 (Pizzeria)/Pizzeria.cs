using Sirenix.OdinInspector;
using UnityEngine;

public class Pizzeria : MonoBehaviour
{
    [Button, BoxGroup("Pizza Spanish")]
    public void SpanishPizza()
    {
        Pizza pizza = new SpanishPizza();
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza Spanish")]
    public void SpanishAnchoviesPizza()
    {
        Pizza pizza = new SpanishPizza();
        pizza = new AnchoviesPizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza Spanish")]
    public void SpanishCheseePizza()
    {
        Pizza pizza = new SpanishPizza();
        pizza = new CheseePizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza Spanish")]
    public void SpanishTomatoPizza()
    {
        Pizza pizza = new SpanishPizza();
        pizza = new TomatoPizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }




    [Button, BoxGroup("Pizza Italian")]
    public void ItalianPizza()
    {
        Pizza pizza = new ItalianPizza();
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza Italian")]
    public void ItalianAnchoviesPizza()
    {
        Pizza pizza = new ItalianPizza();
        pizza = new AnchoviesPizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza Italian")]
    public void ItalianCheseePizza()
    {
        Pizza pizza = new ItalianPizza();
        pizza = new CheseePizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza Italian")]
    public void ItalianTomatoPizza()
    {
        Pizza pizza = new ItalianPizza();
        pizza = new TomatoPizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }




    [Button, BoxGroup("Pizza French")]
    public void FrenchPizza()
    {
        Pizza pizza = new FrenchPizza();
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza French")]
    public void FrenchAnchoviesPizza()
    {
        Pizza pizza = new FrenchPizza();
        pizza = new AnchoviesPizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza French")]
    public void FrenchCheseePizza()
    {
        Pizza pizza = new FrenchPizza();
        pizza = new CheseePizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }

    [Button, BoxGroup("Pizza French")]
    public void FrenchTomatoPizza()
    {
        Pizza pizza = new FrenchPizza();
        pizza = new TomatoPizza(pizza);
        Debug.Log($"Name= {pizza.Name} Cost= {pizza.GetCost()}");
    }
}
