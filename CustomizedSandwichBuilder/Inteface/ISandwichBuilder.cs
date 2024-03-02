using CustomizedSandwichBuilder.Models;

namespace CustomizedSandwichBuilder.Inteface;

public interface ISandwichBuilder
{
    void AddBread();
    void AddProtein();
    void AddVegetables();
    void AddSauce();
    Sandwich GetSandwich();
}
