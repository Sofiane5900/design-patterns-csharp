// See https://aka.ms/new-console-template for more information


using design_patterns.Abstract_Factory;
using design_patterns.Factory;
using design_patterns.Prototype;
using design_patterns.Singleton;

// Singleton
Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.Instance;
Console.WriteLine(ReferenceEquals(instance1,instance2));


// Factory
Robot robotFactoryOne = new Robot("1");
Robot robotFactoryTwo = new Robot("2");
Robot robotFactoryThree = new Robot("3");

var robotFactory = new RobotFactory();

robotFactory.GetRobotNumber(robotFactoryOne).CreateProduct();
robotFactory.GetRobotNumber(robotFactoryTwo).CreateProduct();
robotFactory.GetRobotNumber(robotFactoryThree).CreateProduct();

// Abstract Factory
var customer = new Customer();
var customerVip = new Customer { Orders = new int[10] };

IVipShoppingFactory factoryOne = GetFactory(customer);
IVipShoppingFactory factoryTwo = GetFactory(customerVip);

var shoppingCartOne = new ShoppingCart(factoryOne);
var shoppingCartTwo = new ShoppingCart(factoryTwo);
Console.WriteLine("Shopping Cart 1 ");
shoppingCartOne.CreateCommand();
Console.WriteLine("Shopping Cart 2 ");
shoppingCartTwo.CreateCommand();


IVipShoppingFactory GetFactory(Customer customer)
{
    if (customer.Orders.Length > 5) return new VipShoppingFactory();
    return new StandardShoppingFactory();
}


// Prototype
var person = new Person("Sofiane");
Console.WriteLine("Name person 1 = " + person.Name);

var dog = new Dog("Pluto", person);
Console.WriteLine("Name dog 1 = " + dog.Name);
Console.WriteLine("Name owner dog 1 = " + dog.Owner.Name);

var dogClone = (Dog)dog.Clone(true);
person.Name = "Sufyan";
Console.WriteLine("Name cloned dog = " + dogClone.Name);
Console.WriteLine("Name owner cloned dog  = " + dogClone.Owner.Name);