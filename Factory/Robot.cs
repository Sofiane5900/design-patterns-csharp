namespace design_patterns.Factory;

public class Robot
{
    public string RobotNumber { get; set; }

    public Factory GetRobotNumber(Robot r)
    {
        if (RobotNumber.StartsWith("1")) return new FactoryImplementationOne();
        if (RobotNumber.StartsWith("2")) return new FactoryImplementationTwo();
        if (RobotNumber.StartsWith("3")) return new FactoryImplementationThree();
        throw new InvalidOperationException("Invalid robot number prefix.");
    }
}
