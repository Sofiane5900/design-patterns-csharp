using design_patterns.Factory;

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
    public RobotBuilder GetRobotNumber(Robot robotNumber)
    {
        if (robotNumber.RobotNumber.StartsWith("1")) return new TypeOneRobot();
        if (robotNumber.RobotNumber.StartsWith("2")) return new TypeTwoRobot();
        if (robotNumber.RobotNumber.StartsWith("3")) return new TypeThreeRobot();

        throw new InvalidOperationException("Invalid robot number prefix.");
    }
}