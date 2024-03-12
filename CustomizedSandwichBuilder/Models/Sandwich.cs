using System.Diagnostics.CodeAnalysis;

namespace CustomizedSandwichBuilder.Models;

public class Sandwich
{
    private List<string> components = new List<string>();

    public void AddComponent(string component)
    {
        components.Add(component);
    }

    public void Display()
    {
        Console.WriteLine("Customized Sandwich Components:");
        foreach (var component in components)
        {
            Console.WriteLine(component);
        }
    }

    public void Something()
    {
        throw new NotImplementedException();
    }
}
