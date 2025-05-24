namespace design_patterns.Factory;

public class Robot
{
    public string RobotNumber { get; set; }

    public Robot(string robotNumber)
    {
        RobotNumber = robotNumber;
    }
}

public class RobotFactory
{
    public Factory GetRobotNumber(Robot robotNumber)
    {
        if (robotNumber.RobotNumber.StartsWith("1")) return new FactoryImplementationOne();
        if (robotNumber.RobotNumber.StartsWith("2")) return new FactoryImplementationTwo();
        if (robotNumber.RobotNumber.StartsWith("3")) return new FactoryImplementationThree();

        throw new InvalidOperationException("Invalid robot number prefix.");
    }
}