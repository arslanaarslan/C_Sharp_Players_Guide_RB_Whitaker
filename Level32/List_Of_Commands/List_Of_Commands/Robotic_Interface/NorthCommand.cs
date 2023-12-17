namespace Robotic_Interface;

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
          robot.Y++;
        }
    }
}