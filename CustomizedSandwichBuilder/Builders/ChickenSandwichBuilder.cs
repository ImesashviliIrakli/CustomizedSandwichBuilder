using CustomizedSandwichBuilder.Inteface;
using CustomizedSandwichBuilder.Models;

namespace CustomizedSandwichBuilder.Builders;

public class ChickenSandwichBuilder : ISandwichBuilder
{
    private Sandwich sandwich = new Sandwich();

    public void AddBread() { sandwich.AddComponent("Multigrain Bread"); }
    public void AddProtein() { sandwich.AddComponent("Grilled Chicken"); }
    public void AddVegetables() { sandwich.AddComponent("Lettuce, Tomato"); }
    public void AddSauce() { sandwich.AddComponent("Mustard, Honey Mustard"); }

    public Sandwich GetSandwich()
    {
        return sandwich;
    }
}
