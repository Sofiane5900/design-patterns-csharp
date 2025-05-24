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
    public static Factory GetRobotNumber(string robotNumber)
    {
        if (robotNumber.StartsWith("1")) return new FactoryImplementationOne();
        if (robotNumber.StartsWith("2")) return new FactoryImplementationTwo();
        if (robotNumber.StartsWith("3")) return new FactoryImplementationThree();

        throw new InvalidOperationException("Invalid robot number prefix.");
    }
}