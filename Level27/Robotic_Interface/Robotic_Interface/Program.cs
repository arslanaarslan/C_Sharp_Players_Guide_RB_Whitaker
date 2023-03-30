// See https://aka.ms/new-console-template for more information

using Robotic_Interface;

Robot robot = new Robot();

for (int i = 0; i < 3; i++)
{
    String command = Console.ReadLine().ToLower();

    switch (command)
    {
        case "on":
            robot.Commands[i] = new OnCommand();
            break;
        case "off":
            robot.Commands[i] = new OffCommand();
            break;
        case "north":
            robot.Commands[i] = new NorthCommand();
            break;
        case "south":
            robot.Commands[i] = new SouthCommand();
            break;
        case "west":
            robot.Commands[i] = new WestCommand();
            break;
        case "east":
            robot.Commands[i] = new EastCommand();
            break;
        default:
            Console.WriteLine("Invalid Command");
            robot.Commands[i] = new OffCommand();
            break;
    }
}

Console.WriteLine();
robot.Run();
   