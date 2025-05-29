// See https://aka.ms/new-console-template for more information


using design_patterns.Abstract_Factory;
using design_patterns.Factory;
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


IVipShoppingFactory GetFactory(Customer customer)
{
    if (customer.Orders.Length > 5) return new VipShoppingFactory();
    return new StandardShoppingFactory();
}
