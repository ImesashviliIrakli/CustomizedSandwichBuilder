using CustomizedSandwichBuilder.Inteface;

namespace CustomizedSandwichBuilder.Director;

public class SandwichMaker
{
    public void Construct(ISandwichBuilder builder)
    {
        builder.AddBread();
        builder.AddProtein();
        builder.AddVegetables();
        builder.AddSauce();
    }
}
