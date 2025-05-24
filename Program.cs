// See https://aka.ms/new-console-template for more information


using design_patterns.Factory;
using design_patterns.Singleton;

// Singleton
Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.Instance;
Console.WriteLine(ReferenceEquals(instance1,instance2));


// Factory
Robot robotOne = new Robot("1");
Robot robotTwo = new Robot("2");
Robot robotThree = new Robot("3");

var robotFactory = new RobotFactory();

robotFactory.GetRobotNumber(robotOne).CreateProduct();
robotFactory.GetRobotNumber(robotTwo).CreateProduct();
robotFactory.GetRobotNumber(robotThree).CreateProduct();