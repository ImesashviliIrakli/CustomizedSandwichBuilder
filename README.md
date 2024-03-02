# Customized Sandwich Builder

This project uses the Builder Pattern to create different sandwiches. The Builder Pattern helps build complex objects by separating the making from the final look. So, you can get various tasty sandwiches with the same process. Enjoy crafting your sandwich masterpieces! 🥪✨

## Builder Pattern Overview

### What is the Builder Pattern?

The ``Builder`` design pattern separates the construction of a complex object from its representation so that the same construction process can create different representations.

### Components:

1. **Product (Sandwich):**
   - Represents the final object to be constructed.

2. **Builder Interface (ISandwichBuilder):**
   - Defines a set of methods for building different components of the product.

3. **Concrete Builders:**
   - Implement the builder interface to construct specific types of products.

4. **Director (SandwichMaker):**
   - Orchestrates the construction process using a builder, guiding the order of construction steps.
