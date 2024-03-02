using CustomizedSandwichBuilder.Builders;
using CustomizedSandwichBuilder.Director;
using CustomizedSandwichBuilder.Inteface;
using CustomizedSandwichBuilder.Models;

SandwichMaker sandwichMaker = new SandwichMaker();

ISandwichBuilder veggieBuilder = new VeggieSandwichBuilder();
sandwichMaker.Construct(veggieBuilder);
Sandwich veggieSandwich = veggieBuilder.GetSandwich();
veggieSandwich.Display();

ISandwichBuilder chickenBuilder = new ChickenSandwichBuilder();
sandwichMaker.Construct(chickenBuilder);
Sandwich chickenSandwich = chickenBuilder.GetSandwich();
chickenSandwich.Display();