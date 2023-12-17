// See https://aka.ms/new-console-template for more information

using Robotic_Interface;

Robot robot = new Robot();

while (true)
{
    String command = Console.ReadLine().ToLower();
    
    if (command == "stop")
    {
        break;
    }

    switch (command)
    {
        case "on":
            robot.Commands.Add(new OnCommand());
            break;
        case "off":
            robot.Commands.Add(new OffCommand());
            break;
        case "north":
            robot.Commands.Add(new NorthCommand());
            break;
        case "south":
            robot.Commands.Add(new SouthCommand());
            break;
        case "west":
            robot.Commands.Add(new WestCommand());
            break;
        case "east":
            robot.Commands.Add(new EastCommand());
            break;
        default:
            Console.WriteLine("Invalid Command");
            robot.Commands.Add(new OffCommand());
            break;
    }
}

Console.WriteLine();
robot.Run();
   