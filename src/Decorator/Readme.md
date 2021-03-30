#Pattern: Decorator

##1. About the pattern

###Specification
Decorator is a pattern where we can use composition of objects to avoid ifs, reduce code coupling and avoid create too much specific classes. It attaches aditional
responsibilities to an object in a dynamic way, allowing for a flexible alternative to subclasses that extends functionalities from the parents. It also satisfies
the [**Open-closed principle**](https://medium.com/@tbaragao/solid-ocp-open-closed-principle-600be0382244).


###Considerations

The program here uses ONLY the Decorator Pattern. With that in mind, there are some drawbacks that could be resolved with the use of other patterns (Factory, Builder)
like:

* We could have too many small classes and quickly lose control;
* There's some complexity necessary to introduce the pattern;
* After we have some decorators, we have to use object instances and add to it god knows how many decorators;


##2. About this project

###The problem

We have a beverage company that has a lot of beverages in it's menu, each one with a cost and a description. We want a way to modelate the system where we can use
this many specifications and also respect the [**Open-closed principle**](https://medium.com/@tbaragao/solid-ocp-open-closed-principle-600be0382244) of software 
development.

The company has, for instance, **HouseBlend**, **expresso**, **Decaf** and **DarkRoast** beverages. We could create those classes and make them inherit from a 
**Beverage** abstract class, but... what if the client whants a beverage with condiments? One approach could be create classes to represent the Beverage with the
condiment (like **ExpressoWithMocha** or **DecafWithSoyAndMocha**), but that whould grow too fast and become just impossible to manage. Another approach could
be make the **Beverage** superclass has some code that can be implemented in it's children that could tell which condiment the children has. Then, the abstract
whould have the logic to add the condiment cost (see bellow).

```csharp
public abstract class Beverage
{
	public string Description { get; protected set; }

	public bool HasMilk { get; private set; }
	public bool HasSoy { get; private set; }
	public bool HasWhip { get; private set; }

	public decimal MilkCost { get; private set; }
	public decimal SoyCost { get; private set; }
	public decimal WhipCost { get; private set; }

	public Beverage(bool hasMilk, bool hasSoy, bool hasWhip)
	{
		HasMilk = HasMilk;
		HasSoy = hasSoy;
		HasWhip = hasWhip;

		MilkCost = 0.10;
		SoyCost = 0.99;
		WhipCost = 1.10;
	}

	public decimal Cost()
	{
		var condimentCost = 0;

		if(HasMilk)
			condimentCost += MilkCost;

		if(HasSoy)
			condimentCost += SoyCost;

		if(HasWhip)
			condimentCost += WhipCost;

		return condimentCost;
	}
}
```
Then, when the children inherit from beverage, it could pass those informations (see bellow and example of a DarkRoast with Milk).

```csharp
public class DarkRoast : Beverage
{
	public DarkRoast() : base(true, false, false)
	{
		Description = "Excelent Dark Roast Coffee";
	}

	public decimal Cost()
	{
		return 1.99 + base.Cost();
	}
}
```

There's a problem though; if we do this way, any time we have to add some more condiment we'd have to go to the Beverage class and add it in there. The 
logic in there (that already looks kind of ugly) could grow exponentially and become a horror to our lives!!! (and whould break the **Open-Close Principle**).

To deal with this, we choose to use the decorator design pattern, and use composition of objects with some polimorphism to make each one responsible for 
it's own costs and values.

###How does the program works




###Classes

We have two types of Domain classes: the one's representing Drinks and the ones representing Condiments. What each one does is auto-explanatory.