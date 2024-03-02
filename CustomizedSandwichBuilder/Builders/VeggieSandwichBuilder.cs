using CustomizedSandwichBuilder.Inteface;
using CustomizedSandwichBuilder.Models;

namespace CustomizedSandwichBuilder.Builders;

public class VeggieSandwichBuilder : ISandwichBuilder
{
    private Sandwich sandwich = new Sandwich();

    public void AddBread() { sandwich.AddComponent("Whole Wheat Bread"); }
    public void AddProtein() { /* No protein for veggie sandwich */ }
    public void AddVegetables() { sandwich.AddComponent("Lettuce, Tomato, Cucumber"); }
    public void AddSauce() { sandwich.AddComponent("Mayonnaise"); }

    public Sandwich GetSandwich()
    {
        return sandwich;
    }
}