namespace Robotic_Interface;

public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered)
        {
          robot.X++;
        }
    }
}