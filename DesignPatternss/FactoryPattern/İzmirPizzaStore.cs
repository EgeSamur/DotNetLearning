namespace DesignPatternss.FactoryPattern;

public class İzmirPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        if (type == "cheese")
            return new CheesePizza();
        if (type == "veggie")
            return new VeggiPizza();
        throw new Exception();
    }
}